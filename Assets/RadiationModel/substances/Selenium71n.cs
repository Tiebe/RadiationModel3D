using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium71n : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium71n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 70.93249d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium71()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    