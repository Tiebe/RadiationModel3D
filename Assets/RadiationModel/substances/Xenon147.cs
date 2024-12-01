using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon147 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon147";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 146.95448d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium147()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium147()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    