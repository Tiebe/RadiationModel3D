using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton79m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton79m";
        public override double halfLife { get; } = 50.0d;
        public override double atomicWeight { get; } = 78.92022d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton79()), new(0.27699999999999997d, new GammaParticle(130010.0, 0.00954)), new(0.016901752000000003d, new GammaParticle(1648.0, 0.75233)), new(0.10851146748762704d, new GammaParticle(12596.0, 0.09843)), new(0.20923923541771508d, new GammaParticle(12649.0, 0.09802)), new(0.05013925971535059d, new GammaParticle(14169.0, 0.0875)), new(0.05519329709465793d, new GammaParticle(14209.0, 0.08726)), new(0.005054037379307339d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    