using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium54";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.93888d;

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
    