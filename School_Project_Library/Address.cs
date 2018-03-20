using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    [Serializable]
    public struct Address
    {
        public string StreetAddress;
        public string City;
        public string ProvinceOrTerritory;


        public Address(string streetAddress, string city, string provinceOrTerritory)
        {
            StreetAddress = streetAddress;
            City = city;
            ProvinceOrTerritory = provinceOrTerritory;
        }
    }
}
