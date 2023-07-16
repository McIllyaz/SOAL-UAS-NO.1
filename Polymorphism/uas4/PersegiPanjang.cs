using System;
namespace uas4
{
	public class PersegiPanjang : BangunDatar
	{
		public double PANJANG { get; set; }
		public double LEBAR { get; set; }

        public override double HitungArea()
        {
            return PANJANG * LEBAR;
        }
    }
}