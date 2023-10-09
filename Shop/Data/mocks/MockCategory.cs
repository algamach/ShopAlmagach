using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks {
    public class MockCategory : IPhonesCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "FaceID", desc = "Современные смартфоны с разблокировкой по лицу" },
                    new Category { categoryName = "TouchID автомобили", desc = "Смартфоны с разблокировкой по отпечатку пальца" }
                };
            }
        }
    }
}
