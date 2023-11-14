using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Henger
    {
        protected double magassag;
        protected double sugar;
        protected static int szuletesSzamlalo;

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo += 1;
        }

        public virtual double Terfogat()
        {
            return Math.Round(Math.PI * Math.Pow(sugar, 2) * magassag,2);
        }

        public override string ToString()
        {
            return $"térfogat:{Terfogat()}; sugár:{sugar}; magasság:{magassag}";
        }
        public double GetMagassag { get => magassag;}
        public double GetSugar { get => sugar;}
        public static int SzuletesSzamlalo { get => szuletesSzamlalo;}
    }
}