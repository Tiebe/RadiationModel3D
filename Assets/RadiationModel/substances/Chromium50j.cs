using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chromium50j : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium50j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 49.96024d;

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
    