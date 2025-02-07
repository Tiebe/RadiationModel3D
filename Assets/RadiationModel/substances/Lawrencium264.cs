using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium264";
        public override double halfLife { get; } = 17640.0d;
        public override double atomicWeight { get; } = 264.1142d;

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
    