using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium120";
        public override double halfLife { get; } = 61.3d;
        public override double atomicWeight { get; } = 119.92068d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine120()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 2.0000000000000002e-07d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon120()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 7e-08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine119()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    