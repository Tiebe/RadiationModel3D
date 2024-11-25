using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium134m";
        public override double halfLife { get; } = 10483.2d;
        public override double atomicWeight { get; } = 133.90687d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium134() }, { 0.010835999999999998d, new GammaParticle(11242.0, 0.11029) }, { 0.126d, new GammaParticle(127502.0, 0.00972) }, { 3.906e-05d, new GammaParticle(138733.0, 0.00894) }, { 0.1557077764788d, new GammaParticle(4749.0, 0.26107) }, { 0.08940220389891518d, new GammaParticle(30625.0, 0.04048) }, { 0.16516202456847437d, new GammaParticle(30973.0, 0.04003) }, { 0.04825260857926885d, new GammaParticle(35089.0, 0.03533) }, { 0.060026245072610444d, new GammaParticle(35414.0, 0.03501) }, { 0.011773636493341599d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    