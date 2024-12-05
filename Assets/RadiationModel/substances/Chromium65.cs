using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium65";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 64.96961d;

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
    