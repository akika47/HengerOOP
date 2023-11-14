using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            this.fajsuly = 7.87;
            this.sugar = sugar;
            this.magassag = magassag;
        }
        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
            this.sugar = sugar;
            this.magassag = magassag;
        }

        public override string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; fajsúly:{fajsuly}";
        }

        public double GetFajsuly { get => fajsuly; set => fajsuly = value; }
    }
}