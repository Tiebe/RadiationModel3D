using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium159m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 158.93459d;

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
    