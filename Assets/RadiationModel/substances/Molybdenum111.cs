using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum111 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum111";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 110.93565d;

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
    