using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium155";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 154.94051d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium155()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    