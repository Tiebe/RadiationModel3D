using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium135m";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 134.9135d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium135()), new(0.28371999999999997d, new GammaParticle(41500.0, 0.02988)), new(0.10496d, new GammaParticle(112400.0, 0.01103)), new(0.9676d, new GammaParticle(203800.0, 0.00608)), new(0.08199999999999999d, new GammaParticle(245600.0, 0.00505)), new(0.0246d, new GammaParticle(316600.0, 0.00392)), new(0.18d, new GammaParticle(5637.0, 0.21995)), new(0.15d, new GammaParticle(35551.0, 0.03488)), new(0.27d, new GammaParticle(36027.0, 0.03441)), new(0.08d, new GammaParticle(40857.0, 0.03035)), new(0.1d, new GammaParticle(41266.0, 0.03005)), new(0.021d, new GammaParticle(41766.0, 0.02969)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    