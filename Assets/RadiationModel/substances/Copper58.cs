using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copper58 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper58";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 57.94453d;

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
    