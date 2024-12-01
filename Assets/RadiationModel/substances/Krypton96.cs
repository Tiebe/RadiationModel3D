using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton96 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton96";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 95.94301d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium96()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.037000000000000005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium96()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    