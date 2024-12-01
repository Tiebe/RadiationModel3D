using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium66";
        public override double halfLife { get; } = 0.042d;
        public override double atomicWeight { get; } = 65.95528d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic66()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    