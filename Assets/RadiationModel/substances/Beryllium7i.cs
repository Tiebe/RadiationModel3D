using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium7i : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium7i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 7.02872d;

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
    