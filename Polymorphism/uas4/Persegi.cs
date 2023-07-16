using System;
namespace uas4
{
	public class Persegi : BangunDatar
	{
		public double SISI { get; set; }

        public override double HitungArea()
        {
            return SISI * SISI;
        }
    }
}