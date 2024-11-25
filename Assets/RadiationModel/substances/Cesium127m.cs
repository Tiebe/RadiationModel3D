using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium127m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 126.9079d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium127() }, { 0.114d, new GammaParticle(65900.0, 0.01881) }, { 0.055999999999999994d, new GammaParticle(72900.0, 0.01701) }, { 0.094d, new GammaParticle(133700.0, 0.00927) }, { 0.024d, new GammaParticle(139000.0, 0.00892) }, { 0.42100000000000004d, new GammaParticle(178800.0, 0.00693) }, { 0.585d, new GammaParticle(206000.0, 0.00602) }, { 0.1d, new GammaParticle(385500.0, 0.00322) }, { 0.15098306834d, new GammaParticle(4749.0, 0.26107) }, { 0.2700314825582833d, new GammaParticle(30625.0, 0.04048) }, { 0.4988573481586612d, new GammaParticle(30973.0, 0.04003) }, { 0.14574275424682917d, new GammaParticle(35089.0, 0.03533) }, { 0.1813039862830555d, new GammaParticle(35414.0, 0.03501) }, { 0.03556123203622632d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    