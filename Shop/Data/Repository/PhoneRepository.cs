using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository {
    public class PhoneRepository : IAllPhones {

        private readonly AppDBContent appDBContent;

        public PhoneRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Phone> Phones => appDBContent.Phone.Include(c => c.Category);

        public IEnumerable<Phone> getFavPhones => appDBContent.Phone.Where(p => p.isFavourite).Include(c => c.Category);

        public Phone getObjectPhone(int phoneId) => appDBContent.Phone.FirstOrDefault(p => p.id == phoneId);
    }
}
