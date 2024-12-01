using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium130";
        public override double halfLife { get; } = 2.492997151992768e+28d;
        public override double atomicWeight { get; } = 129.90622d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon130()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    