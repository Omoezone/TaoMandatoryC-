using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAO_Project.Models
{
    public class Discounts
    {
        public List<Calculator> calculators
        {
            get; set;
        }
        public void FillList()
        {
            this.calculators.Add(new Calculator("Udskiftning af vinduer", 16500, 1500));
            this.calculators.Add(new Calculator("Montering af forsatsvindue", 12100, 1400));
            this.calculators.Add(new Calculator("Udskiftning af ovenlys", 6000, 300));
            this.calculators.Add(new Calculator("Udskiftning af terassedør og lignende", 3000, 300));
            this.calculators.Add(new Calculator("Isolering af let ydervæg", 16440, 1500));
            this.calculators.Add(new Calculator("Isolering af massiv ydervæg", 64390, 12800));
            this.calculators.Add(new Calculator("Isolering af loft", 4860, 400));
            this.calculators.Add(new Calculator("Isolering af fladt tag", 5400, 400));
            this.calculators.Add(new Calculator("Isolering af tag med høj rejsning", 6480, 400));
            this.calculators.Add(new Calculator("Efterisolering af terrændæk", 8330, 400));
            this.calculators.Add(new Calculator("Efterisolering af sokkel", 15300, 1000));
            this.calculators.Add(new Calculator("Ventilation med varmegenindvinding", 14000, 1200));
        }

        public Discounts()
        {
            this.calculators = new List<Calculator>();
        }
    }
}