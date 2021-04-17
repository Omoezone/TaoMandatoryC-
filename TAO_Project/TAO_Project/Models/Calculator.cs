using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAO_Project.Models
{
    public class Calculator
    {

        public string energyImprovement
        {
            get; set;
        }

        public int grant
        {
            get; set;
        }

        public int yearlyDiscount
        {
            get; set;
        }

        public Calculator(string energyImprovement, int grant, int yearlyDiscount)
        {
            this.energyImprovement = energyImprovement;
            this.grant = grant;
            this.yearlyDiscount = yearlyDiscount;
        }

        public override string ToString()
        {
            return this.energyImprovement;
        }
    }
}