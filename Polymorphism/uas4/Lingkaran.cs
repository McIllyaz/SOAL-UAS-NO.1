using System;
namespace uas4
{
    public class Lingkaran : BangunDatar
    {
        public double JARI_JARI { get; set; }

        public override double HitungArea()
        {
            return Math.PI * JARI_JARI * JARI_JARI;
        }
    }
}