using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Manganese65 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese65";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 64.95602d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron65()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.079d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron65()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    