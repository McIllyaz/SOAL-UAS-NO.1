using System;
namespace uas4
{
	public class Trapesium : BangunDatar
	{
        public double SISIA { get; set; }
        public double SISIB { get; set; }
        public double TINGGI { get; set; }

        public override double HitungArea()
        {
            double SISIAB = SISIA + SISIB;
            return SISIAB / 2 * TINGGI;
        }
    }
}