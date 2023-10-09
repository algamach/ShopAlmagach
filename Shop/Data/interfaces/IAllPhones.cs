using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces {
    public interface IAllPhones {

        IEnumerable<Phone> Phones { get; }
        IEnumerable<Phone> getFavPhones { get; }
        Phone getObjectPhone(int phoneId);

    }
}
