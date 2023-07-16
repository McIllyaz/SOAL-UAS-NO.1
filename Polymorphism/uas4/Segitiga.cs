using System;
namespace uas4
{
    public class Segitiga : BangunDatar
    {
        public double ALAS { get; set; }
        public double TINGGI { get; set; }

        public override double HitungArea()
        {
            return ALAS * TINGGI / 2;
        }
    }
}