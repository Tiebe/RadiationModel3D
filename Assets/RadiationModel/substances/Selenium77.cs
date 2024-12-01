using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium77";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 76.91991d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    