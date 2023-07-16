using System;
namespace uas5
{
	public class Kerucut : BangunRuang
	{
        public double JARI_JARI { get; set; }
        public double TINGGI { get; set; }

        public override double HitungVolume()
        {
            return Math.PI * JARI_JARI * JARI_JARI * TINGGI / 3;
        }
    }
}