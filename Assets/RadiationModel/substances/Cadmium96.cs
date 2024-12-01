using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cadmium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium96";
        public override double halfLife { get; } = 1.03d;
        public override double atomicWeight { get; } = 95.94034d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    