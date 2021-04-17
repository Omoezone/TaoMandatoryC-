using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAO_Project.Models
{
    public class Address
    {

        public int zipCode
        {
            get; set;
        }

        public string streetName
        {
            get; set; 
        }

        public int streetNumber
        {
            get; set;
        }

        public Address(int zipCode, string streetName, int streetNumber)
        {
            this.zipCode = zipCode;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
        }
    }
}