using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium121";
        public override double halfLife { get; } = 23.1d;
        public override double atomicWeight { get; } = 120.90785d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin121() }, { 1.0d, new BetaParticle(-1, 1680800.0) }, { 0.0019d, new GammaParticle(56350.0, 0.022) }, { 0.00065d, new GammaParticle(60340.0, 0.02055) }, { 0.079d, new GammaParticle(261960.0, 0.00473) }, { 0.071d, new GammaParticle(657320.0, 0.00189) }, { 0.0022d, new GammaParticle(808700.0, 0.00153) }, { 0.011000000000000001d, new GammaParticle(869310.0, 0.00143) }, { 0.042d, new GammaParticle(919280.0, 0.00135) }, { 0.87d, new GammaParticle(925570.0, 0.00134) }, { 0.0034000000000000002d, new GammaParticle(1092800.0, 0.00113) }, { 0.00122254038252d, new GammaParticle(3753.0, 0.33036) }, { 0.0029747113316492433d, new GammaParticle(25044.0, 0.04951) }, { 0.00556749266638451d, new GammaParticle(25271.0, 0.04906) }, { 0.0015742775287938566d, new GammaParticle(28579.0, 0.04338) }, { 0.0018844102019662462d, new GammaParticle(28810.0, 0.04304) }, { 0.0003101326731723897d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    