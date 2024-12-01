using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thallium201 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium201";
        public override double halfLife { get; } = 262828.8d;
        public override double atomicWeight { get; } = 200.97082d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mercury201()), new(1.1000000000000001e-05d, new GammaParticle(1564.8, 0.79233)), new(7e-07d, new GammaParticle(5895.0, 0.21032)), new(8.2e-05d, new GammaParticle(26273.8, 0.04719)), new(0.0025800000000000003d, new GammaParticle(30600.0, 0.04052)), new(0.00263d, new GammaParticle(32190.0, 0.03852)), new(0.02605d, new GammaParticle(135340.0, 0.00916)), new(2.6e-05d, new GammaParticle(141100.0, 0.00879)), new(0.00147d, new GammaParticle(165880.0, 0.00747)), new(0.1d, new GammaParticle(167430.0, 0.00741)), new(0.42200000000000004d, new GammaParticle(11777.0, 0.10528)), new(0.27d, new GammaParticle(68894.0, 0.018)), new(0.45799999999999996d, new GammaParticle(70820.0, 0.01751)), new(0.155d, new GammaParticle(80316.0, 0.01544)), new(0.201d, new GammaParticle(81285.0, 0.01525)), new(0.0455d, new GammaParticle(82477.0, 0.01503)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    