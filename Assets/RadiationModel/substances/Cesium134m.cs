using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cesium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium134m";
        public override double halfLife { get; } = 10483.2d;
        public override double atomicWeight { get; } = 133.90687d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cesium134()), new(0.010835999999999998d, new GammaParticle(11242.0, 0.11029)), new(0.126d, new GammaParticle(127502.0, 0.00972)), new(3.906e-05d, new GammaParticle(138733.0, 0.00894)), new(0.1557077764788d, new GammaParticle(4749.0, 0.26107)), new(0.08940220389891518d, new GammaParticle(30625.0, 0.04048)), new(0.16516202456847437d, new GammaParticle(30973.0, 0.04003)), new(0.04825260857926885d, new GammaParticle(35089.0, 0.03533)), new(0.060026245072610444d, new GammaParticle(35414.0, 0.03501)), new(0.011773636493341599d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    