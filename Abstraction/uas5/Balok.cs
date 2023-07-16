using System;
namespace uas5
{
    public class Balok : BangunRuang
    {
        public double PANJANG { get; set; }
        public double LEBAR { get; set; }
        public double TINGGI { get; set; }

        public override double HitungVolume()
        {
            return PANJANG * LEBAR * TINGGI;
        }
    }
}