using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic83 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic83";
        public override double halfLife { get; } = 13.4d;
        public override double atomicWeight { get; } = 82.92521d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium83()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    