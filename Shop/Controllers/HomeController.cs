using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class HomeController : Controller {

        private IAllPhones _phoneRep;

        public HomeController(IAllPhones phoneRep) {
            _phoneRep = phoneRep;
        }

        public ViewResult Index() {
            var homePhones = new HomeViewModel {
                favPhones = _phoneRep.getFavPhones
            };

            ViewBag.Title = "ALMAGACH";

            return View(homePhones);
        }

    }
}
