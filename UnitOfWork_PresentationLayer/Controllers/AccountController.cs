using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using UnitOfWork_BusinessLayer.Abstract;
using UnitOfWork_DAL.Concrete;
using UnitOfWork_EntityLayer.Concrete;
using UnitOfWork_PresentationLayer.Models;

namespace UnitOfWork_PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);
            value1.Balance -= p.Amount;
            value2.Balance += p.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
