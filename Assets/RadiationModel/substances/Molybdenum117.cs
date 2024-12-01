using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum117 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum117";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 116.96169d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
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
    