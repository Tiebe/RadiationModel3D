using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum138 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum138";
        public override double halfLife { get; } = 3.250363375382976e+18d;
        public override double atomicWeight { get; } = 137.90712d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.655d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium138() }, { 1.0d, new BetaParticle(1, -1813200.0) }, { 0.655d, new GammaParticle(1435795.0, 0.00086) }, { 0.060639500581d, new GammaParticle(4966.0, 0.24967) }, { 0.10644552743003649d, new GammaParticle(31816.0, 0.03897) }, { 0.1961045088983723d, new GammaParticle(32193.0, 0.03851) }, { 0.057682662676989765d, new GammaParticle(36482.0, 0.03399) }, { 0.07221869367159119d, new GammaParticle(36827.0, 0.03367) }, { 0.014536030994601419d, new GammaParticle(37255.0, 0.03328) } } },
            { 0.345d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium138() }, { 1.0d, new BetaParticle(-1, 526250.0) }, { 0.345d, new GammaParticle(788742.0, 0.00157) }, { 0.00012744127500000001d, new GammaParticle(5410.0, 0.22918) }, { 0.00025930538053004236d, new GammaParticle(34279.0, 0.03617) }, { 0.00047491827935905196d, new GammaParticle(34720.0, 0.03571) }, { 0.00014303894745686265d, new GammaParticle(39366.0, 0.0315) }, { 0.00017937084011090574d, new GammaParticle(39753.0, 0.03119) }, { 3.633189265404311e-05d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    