using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium113";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 112.94443d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon112()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    