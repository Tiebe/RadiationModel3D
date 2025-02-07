using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium170";
        public override double halfLife { get; } = 55.0d;
        public override double atomicWeight { get; } = 169.94234d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium170()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    