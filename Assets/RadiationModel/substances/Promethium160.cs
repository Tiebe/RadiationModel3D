using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Promethium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium160";
        public override double halfLife { get; } = 0.725d;
        public override double atomicWeight { get; } = 159.94322d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium160()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    