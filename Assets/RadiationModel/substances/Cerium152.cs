using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cerium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium152";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 151.93668d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Praseodymium152()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    