using System;
namespace uas5
{
    public class Kubus : BangunRuang
    {
        public double SISI { get; set; }

        public override double HitungVolume()
        {
            return SISI * SISI * SISI;
        }
    }
}