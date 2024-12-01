using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radon228 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon228";
        public override double halfLife { get; } = 65.0d;
        public override double atomicWeight { get; } = 228.03783d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium228()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    