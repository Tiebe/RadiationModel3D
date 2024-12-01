using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium118";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 117.92656d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine118()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00042d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine117()), new(1.0d, new ProtonParticle()) } },
            { 2.3999999999999997e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium114()), new(1.0d, new AlphaParticle(12078002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    