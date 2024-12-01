using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium116";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 115.9334d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine116()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.027999999999999997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine115()), new(1.0d, new ProtonParticle()) } },
            { 0.00049d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium112()), new(1.0d, new AlphaParticle(14125002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    