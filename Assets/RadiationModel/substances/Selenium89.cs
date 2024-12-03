using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium89";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 88.93667d;

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
    