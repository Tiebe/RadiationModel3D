using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium135m";
        public override double halfLife { get; } = 3180.0d;
        public override double atomicWeight { get; } = 134.90773d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium135() }, { 0.997d, new GammaParticle(787200.0, 0.00158) }, { 0.96d, new GammaParticle(846100.0, 0.00147) }, { 0.0039598468d, new GammaParticle(4749.0, 0.26107) }, { 0.009174188622234737d, new GammaParticle(30625.0, 0.04048) }, { 0.01694843639799508d, new GammaParticle(30973.0, 0.04003) }, { 0.004951539372805619d, new GammaParticle(35089.0, 0.03533) }, { 0.00615971497977019d, new GammaParticle(35414.0, 0.03501) }, { 0.001208175606964571d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    