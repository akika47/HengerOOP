using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Cso : Henger
    {
        double falVastagsag;

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falVastagsag = 1;
            this.sugar = sugar;
            this.magassag = magassag;
        }
        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
            this.sugar = sugar;
            this.magassag = magassag;
        }

        public override double Terfogat()
        {
            double egyikterulet = Math.Round(Math.PI * Math.Pow(sugar, 2) * magassag, 2);
            double masikterulet = Math.Round(Math.PI * Math.Pow(sugar - falVastagsag, 2) * magassag, 2);
            return Math.Round(egyikterulet-masikterulet,2);
        }

        public override string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}; falvastagsága:{falVastagsag}";
        }

        public double FalVastagsag { get => falVastagsag;}
    }
}