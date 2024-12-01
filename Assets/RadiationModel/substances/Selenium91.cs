using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium91";
        public override double halfLife { get; } = 0.27d;
        public override double atomicWeight { get; } = 90.9457d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine91()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.21d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine91()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    