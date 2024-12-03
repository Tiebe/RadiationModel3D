using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium136m";
        public override double halfLife { get; } = 17.5d;
        public override double atomicWeight { get; } = 135.90787d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium136()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    