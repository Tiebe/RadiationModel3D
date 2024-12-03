using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Mercury193m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury193m";
        public override double halfLife { get; } = 42480.0d;
        public override double atomicWeight { get; } = 192.9668d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9279999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum193()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.07200000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury193()), new(0.0032d, new GammaParticle(39510.0, 0.03138)), new(1.14e-05d, new GammaParticle(101250.0, 0.01225)), new(0.03625653979d, new GammaParticle(11777.0, 0.10528)), new(0.000544346983239221d, new GammaParticle(68894.0, 0.018)), new(0.0009227784086103085d, new GammaParticle(70820.0, 0.01751)), new(0.0003131682971001316d, new GammaParticle(80316.0, 0.01544)), new(0.0004049266081504702d, new GammaParticle(81285.0, 0.01525)), new(9.175831105033857e-05d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    