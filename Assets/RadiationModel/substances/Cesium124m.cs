using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium124m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium124m";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 123.91274d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium124()), new(0.063d, new GammaParticle(53850.0, 0.02302)), new(0.1845d, new GammaParticle(58200.0, 0.0213)), new(0.0225d, new GammaParticle(64900.0, 0.0191)), new(0.465d, new GammaParticle(89500.0, 0.01385)), new(0.4575d, new GammaParticle(96550.0, 0.01284)), new(0.0075d, new GammaParticle(161000.0, 0.0077)), new(0.051d, new GammaParticle(169500.0, 0.00731)), new(0.24d, new GammaParticle(188980.0, 0.00656)), new(0.495d, new GammaParticle(211640.0, 0.00586)), new(0.09300000000000001d, new GammaParticle(270300.0, 0.00459)), new(0.225111546036d, new GammaParticle(4749.0, 0.26107)), new(0.49220873569573503d, new GammaParticle(30625.0, 0.04048)), new(0.9093085824787273d, new GammaParticle(30973.0, 0.04003)), new(0.26565738233564157d, new GammaParticle(35089.0, 0.03533)), new(0.33047778362553815d, new GammaParticle(35414.0, 0.03501)), new(0.06482040128989655d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    