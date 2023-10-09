using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks {
    public class MockPhones : IAllPhones {

        private readonly IPhonesCategory _categoryPhones = new MockCategory();

        public IEnumerable<Phone> Phones {
            get {
                return new List<Phone> {
                    new Phone {
                        name = "афоня11промах",
                        shortDesc = "Чоткий тел",
                        longDesc = "Красивый, быстрый и очень классный",
                        img = "/img/11promax.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone {
                        name = "11pro",
                        shortDesc = "мощьный смарт",
                        longDesc = "Классный телефончег",
                        img = "/img/11pro.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone {
                        name = "iPhone 8",
                        shortDesc = "Удобный смартфон",
                        longDesc = "Удобный смарт для людей",
                        img = "/img/8.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.Last()
                    },
                    new Phone {
                        name = "xr",
                        shortDesc = "лучшый выбор",
                        longDesc = "Самый народный айфон 2019",
                        img = "/img/xr.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone {
                        name = "SE",
                        shortDesc = "неоднозначный тел",
                        longDesc = "Хороший смарт, но не за свои деньги",
                        img = "/img/se.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryPhones.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Phone> getFavPhones { get; set; }

        public Phone getObjectPhone(int phoneId) {
            throw new NotImplementedException();
        }
    }
}
