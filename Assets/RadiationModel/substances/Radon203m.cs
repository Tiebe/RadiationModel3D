using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon203m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203m";
        public override double halfLife { get; } = 26.9d;
        public override double atomicWeight { get; } = 202.99375d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.75d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium199()), new(1.0d, new AlphaParticle(8014002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium203()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    