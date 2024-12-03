using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Titanium45m : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium45m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 44.95816d;

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
    