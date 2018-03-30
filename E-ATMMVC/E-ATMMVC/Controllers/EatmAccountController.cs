using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI.WebControls;
using E_ATMMVC.Models;

namespace E_ATMMVC.Controllers
{
    public class EatmAccountController : Controller
    {
        Dictionary<int, int> tranction = new Dictionary<int, int>();
        public EatmDbContext ctx;
        public AccountModel Account;

        public EatmAccountController()
        {
            ctx = new EatmDbContext();            
        }

        public ActionResult Details(AccountModel account, E_ATMMVC.Models.EatmDbContext context)
        {
            var accounts = ctx.AccountModels.FirstOrDefault(a => a.CardNumber == account.CardNumber && a.PinNumber == account.PinNumber);

            if (accounts==null)
            {
                ViewBag.errorMessege = "Your Card Number and Pin Number doesn't match";
                return RedirectToAction("Login","EatmAccount");
            }
            else
            {
               return RedirectToAction("Option", new {cardNumber=account.CardNumber});
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            var error = ViewBag.errorMessage;
            return View();
        }
        [Route("EatmAccount/{cardNumber}/Option")]
        public ActionResult Option(int cardNumber)
        {
            var account = GetAccount(cardNumber);
            return View(account);
        
        }
        [Route("EatmAccount/{cardNumber}/BalanceCheck")]
        public ActionResult BalanceCheck(int cardNumber)
        {
            var account = GetAccount(cardNumber);
            return View(account);
        }

        [Route("EatmAccount/{cardNumber}/CashWithdrawal")]
        public ActionResult CashWithdrawal(int cardNumber)
        {
            var account = GetAccount(cardNumber);
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

        private AccountModel GetAccount(int cardNumber)
        {
            return ctx.AccountModels.FirstOrDefault(a => a.CardNumber == cardNumber);
        }
    }
}