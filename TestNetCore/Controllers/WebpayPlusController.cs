using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transbank.Webpay.WebpayPlus;

namespace TestNetCore.Controllers
{
    public class WebpayPlusController : Controller
    {
        #region Webpay Plus

        public ActionResult NormalCreate()
        {
            var random = new Random();
            var buyOrder = random.Next(999999999).ToString();
            var sessionId = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0')
                        + DateTime.Now.Day.ToString().PadLeft(2, '0') + '-' + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0')
                        + DateTime.Now.Second.ToString().PadLeft(2, '0') + "-" + random.Next(999999999).ToString();
            var amount = random.Next(1000, 999999);
            //var urlHelper = new UrlHelper(ControllerContext.RequestContext);
            var returnUrl = Url.Action("NormalReturn", "WebpayPlus", null, this.Request.Scheme);
            var result = Transaction.Create(buyOrder, sessionId, amount, returnUrl);

            ViewBag.BuyOrder = buyOrder;
            ViewBag.SessionId = sessionId;
            ViewBag.Amount = amount;
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.Result = result;
            ViewBag.Action = result.Url;
            ViewBag.Token = result.Token;
            return View();
        }

        [HttpPost]
        public ActionResult NormalReturn()
        {
            var token = Request.Form["token_ws"];
            var result = Transaction.Commit(token);

            //var urlHelper = new UrlHelper(ControllerContext.RequestContext);

            ViewBag.Token = token;
            ViewBag.Action = Url.Action("ExecuteRefund", "WebpayPlus", null, this.Request.Scheme);
            ViewBag.Result = result;
            ViewBag.SaveToken = token;

            return View();
        }

        public ActionResult NormalRefund()
        {
            //var urlHelper = new UrlHelper(ControllerContext.RequestContext);
            ViewBag.Action = Url.Action("ExecuteRefund", "WebpayPlus", null, this.Request.Scheme);
            return View();
        }

        [HttpPost]
        public ActionResult ExecuteRefund()
        {
            var token = Request.Form["token_ws"];
            var refundAmount = 500;
            var result = Transaction.Refund(token, refundAmount);

            //var urlHelper = new UrlHelper(ControllerContext.RequestContext);
            ViewBag.Action = Url.Action("ExecuteStatus", "WebpayPlus", null, this.Request.Scheme);

            ViewBag.Token = token;
            ViewBag.Amount = refundAmount;
            ViewBag.Result = result;

            return View();
        }


        public ActionResult NormalStatus()
        {
            //var urlHelper = new UrlHelper(ControllerContext.RequestContext);
            ViewBag.Action = Url.Action("ExecuteStatus", "WebpayPlus", null, this.Request.Scheme);
            return View();
        }

        [HttpPost]
        public ActionResult ExecuteStatus()
        {
            var token = Request.Form["token_ws"];
            var result = Transaction.Status(token);

            ViewBag.Result = result;

            return View();
        }

        #endregion Webpay Plus

    }
}

