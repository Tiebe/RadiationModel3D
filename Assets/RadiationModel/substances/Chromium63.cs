using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium63";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 62.96116d;

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
    