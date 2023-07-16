using System;
namespace uas5
{
	public class Limas : BangunRuang
	{
        public double SISI { get; set; }
        public double TINGGI { get; set; }

        public override double HitungVolume()
        {
            return SISI * SISI * TINGGI / 3;
        }
    }
}