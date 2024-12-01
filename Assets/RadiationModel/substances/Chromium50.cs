using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium50";
        public override double halfLife { get; } = 4.10240037669696e+25d;
        public override double atomicWeight { get; } = 49.94604d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
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
    