using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium116m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 115.9335d;

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
    