using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data {
    public class DBObjects {
        public static void Initial(AppDBContent content) {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Phone.Any()) {
                content.AddRange(
                   new Phone
                   {
                       name = "iPhone 11 Pro Max",
                       shortDesc = "Большой фалгманский смартфон Apple",
                       longDesc = "Apple",
                       img = "/img/11promax.jpg",
                       price = 99990,
                       isFavourite = true,
                       available = true,
                       Category = Categories["FaceID"]
                   },
                   new Phone
                   {
                       name = "iPhone 11 Pro",
                       shortDesc = "Флагманский смартфон Apple",
                       longDesc = "Apple",
                       img = "/img/11pro.jpg",
                       price = 89990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone
                   {
                       name = "iPhone 11",
                       shortDesc = "Яркий мощный iPhone",
                       longDesc = "Apple",
                       img = "/img/11u.jpg",
                       price = 59990,
                       isFavourite = true,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone
                   {
                       name = "iPhone XS Max",
                       shortDesc = "Большой iPhone с премиальным дизайном",
                       longDesc = "Apple",
                       img = "/img/xsmax.jpg",
                       price = 64990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone
                   {
                       name = "iPhone XS",
                       shortDesc = "iPhone с премиальным дизайном",
                       longDesc = "Apple",
                       img = "/img/xs.jpg",
                       price = 54990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone
                   {
                       name = "iPhone X",
                       shortDesc = "Первый iPhone с FaceID",
                       longDesc = "Apple",
                       img = "/img/x.jpg",
                       price = 44990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone                   
                   {
                       name = "iPhone XR",
                       shortDesc = "Самый популярный iPhone 2019",
                       longDesc = "Apple",
                       img = "/img/xr.jpg",
                       price = 49990,
                       isFavourite = true,
                       available = true,
                       Category = Categories["FaceID"]
                   }, new Phone
                   {
                       name = "iPhone SE (2020)",
                       shortDesc = "Самый мощный и самый дешевый iPhone",
                       longDesc = "Apple",
                       img = "/img/se2.jpg",
                       price = 39990,
                       isFavourite = true,
                       available = true,
                       Category = Categories["TouchID"]
                   }, new Phone
                   {
                       name = "iPhone 8 Plus",
                       shortDesc = "Последний iPhone с 5.5 экраном",
                       longDesc = "Apple",
                       img = "/img/8plus.jpg",
                       price = 39990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["TouchID"]
                   }, new Phone
                   {
                       name = "iPhone 8",
                       shortDesc = "Бюджетный iPhone",
                       longDesc = "Apple",
                       img = "/img/8.jpg",
                       price = 35990,
                       isFavourite = false,
                       available = true,
                       Category = Categories["TouchID"]
                   }
                   );
                   
               
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if(category == null) {
                    var list = new Category[] {
                        new Category { categoryName = "FaceID", desc = "Смартфоны нового поколения с разблокировкой по лицу" },
                        new Category { categoryName = "TouchID", desc = "Смартфоны с раблокировкой по отпечатку пальца" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }

                return category;
            }
        }
    }
}
