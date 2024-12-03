using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium123m";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 122.91316d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium123()), new(0.003444d, new GammaParticle(61700.0, 0.02009)), new(0.04305d, new GammaParticle(64000.0, 0.01937)), new(0.287d, new GammaParticle(94600.0, 0.01311)), new(0.1524359925088d, new GammaParticle(4749.0, 0.26107)), new(0.1549666442476625d, new GammaParticle(30625.0, 0.04048)), new(0.28628605994395434d, new GammaParticle(30973.0, 0.04003)), new(0.08363937913857172d, new GammaParticle(35089.0, 0.03533)), new(0.10404738764838324d, new GammaParticle(35414.0, 0.03501)), new(0.020408008509811504d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    