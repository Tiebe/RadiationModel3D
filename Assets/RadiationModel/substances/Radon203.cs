using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon203 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon203";
        public override double halfLife { get; } = 44.2d;
        public override double atomicWeight { get; } = 202.99336d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.66d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium199()), new(1.0d, new AlphaParticle(7652002.09)) } },
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium203()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    