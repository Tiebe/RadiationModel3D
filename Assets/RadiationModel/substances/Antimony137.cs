using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Antimony137 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony137";
        public override double halfLife { get; } = 0.45d;
        public override double atomicWeight { get; } = 136.93552d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.49d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium137()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    