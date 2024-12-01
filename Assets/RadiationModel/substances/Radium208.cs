using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium208";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 208.00186d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon204()), new(1.0d, new AlphaParticle(8295002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon208()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    