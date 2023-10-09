using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class PhonesController : Controller {

        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _allCategories;

        public PhonesController(IAllPhones iAllPhones, IPhonesCategory iPhonesCat) {
            _allPhones = iAllPhones;
            _allCategories = iPhonesCat;
        }

        [Route("Phones/List")]
        [Route("Phones/List/{category}")]
        public ViewResult List(string category) {
            string _category = category;
            IEnumerable<Phone> phones = null;
            string currCategory = "";
            if(string.IsNullOrEmpty(category)) {
                phones = _allPhones.Phones.OrderBy(i => i.id);
            } else {
                if(string.Equals("face", category, StringComparison.OrdinalIgnoreCase)) {
                    phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("FaceID")).OrderBy(i => i.id);
                    currCategory = "FaceID";
                } else if (string.Equals("touch", category, StringComparison.OrdinalIgnoreCase)) {
                    phones = _allPhones.Phones.Where(i => i.Category.categoryName.Equals("TouchID")).OrderBy(i => i.id);
                    currCategory = "TouchID";
                }
            }

            var phoneObj = new PhonesListViewModel {
                allPhones = phones,
                currCategory = currCategory
            };

            ViewBag.Title = "ALMAGACH";
            

            return View(phoneObj);
        }


    }
}
