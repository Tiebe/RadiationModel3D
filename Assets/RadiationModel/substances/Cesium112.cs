using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium112";
        public override double halfLife { get; } = 0.00049d;
        public override double atomicWeight { get; } = 111.95017d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon111()), new(1.0d, new ProtonParticle()) } },
            { 0.0026d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine108()), new(1.0d, new AlphaParticle(4947002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    