using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium262";
        public override double halfLife { get; } = 14400.0d;
        public override double atomicWeight { get; } = 262.10962d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    