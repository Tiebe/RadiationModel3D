using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium260";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 260.10644d;

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
    