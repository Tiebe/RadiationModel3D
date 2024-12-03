using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium125m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium125m";
        public override double halfLife { get; } = 0.0009d;
        public override double atomicWeight { get; } = 124.91001d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium125()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    