using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Praseodymium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium158";
        public override double halfLife { get; } = 0.181d;
        public override double atomicWeight { get; } = 157.9526d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium158()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
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
    