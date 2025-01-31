﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.Interfaces;

namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Controller
    {
        private IUserService _userService;

        public WalletController(IUserService userService)
        {
            _userService = userService;
        }



        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public ActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userService.GetWalletUser(User.Identity.Name);
                return View(charge);
            }

            int walletId = _userService.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ حساب");

            #region Online Payment

            var payment = new Zarinpal.Payment("365d6960-fee8-441d-add6-1db78a6bee14", charge.Amount);
            var res = payment.PaymentRequest("شارژ کیف پول", "https://freeeducation.ir/OnlinePayment/" + walletId, "testTopLearn84@freeeducation.ir", "09149638014");

            if (res.Result.Status == 100)
            {
                return Redirect("https://zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            #endregion

            return null;
        }
    }
}