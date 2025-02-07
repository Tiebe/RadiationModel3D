using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium137";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 136.92701d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium137()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    