using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium93";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 92.95613d;

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
    