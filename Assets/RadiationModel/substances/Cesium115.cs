using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium115";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 114.93591d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine115()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0007000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine114()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    