using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium118";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 117.92656d;

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
    