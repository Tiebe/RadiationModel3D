using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium121m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 120.9173d;

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
    