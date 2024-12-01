using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium130";
        public override double halfLife { get; } = 2.6d;
        public override double atomicWeight { get; } = 129.94045d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium130()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.7d, new GammaParticle(158900.0, 0.0078)), new(0.76d, new GammaParticle(326300.0, 0.0038)), new(0.44d, new GammaParticle(454200.0, 0.00273)), new(0.13d, new GammaParticle(547200.0, 0.00227)), new(0.07d, new GammaParticle(787400.0, 0.00157)), new(0.07d, new GammaParticle(793400.0, 0.00156)), new(0.09d, new GammaParticle(1026200.0, 0.00121)), new(0.038940631520000005d, new GammaParticle(5870.0, 0.21122)), new(0.060731553403603124d, new GammaParticle(36848.0, 0.03365)), new(0.11060199126498475d, new GammaParticle(37362.0, 0.03318)), new(0.033966841154663564d, new GammaParticle(42380.0, 0.02926)), new(0.0426963193314121d, new GammaParticle(42810.0, 0.02896)), new(0.008729478176748537d, new GammaParticle(43335.0, 0.02861)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    