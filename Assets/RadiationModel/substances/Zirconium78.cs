using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zirconium78 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium78";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.95615d;

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
    