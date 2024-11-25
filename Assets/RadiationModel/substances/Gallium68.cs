using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium68";
        public override double halfLife { get; } = 4062.6d;
        public override double atomicWeight { get; } = 67.92798d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper68() }, { 1.0d, new BetaParticle(1, -759550.0) }, { 1.1914e-06d, new GammaParticle(227310.0, 0.00545) }, { 2.6404e-06d, new GammaParticle(483350.0, 0.00257) }, { 0.00033487999999999997d, new GammaParticle(578520.0, 0.00214) }, { 3.1233999999999996e-06d, new GammaParticle(682630.0, 0.00182) }, { 0.00094024d, new GammaParticle(805830.0, 0.00154) }, { 1.7709999999999999e-06d, new GammaParticle(938730.0, 0.00132) }, { 0.0322d, new GammaParticle(1077340.0, 0.00115) }, { 1.6099999999999997e-07d, new GammaParticle(1165920.0, 0.00106) }, { 0.00094346d, new GammaParticle(1261080.0, 0.00098) }, { 1.3e-07d, new GammaParticle(1659000.0, 0.00075) }, { 9.499000000000001e-05d, new GammaParticle(1744420.0, 0.00071) }, { 0.0013652800000000002d, new GammaParticle(1883160.0, 0.00066) }, { 1.1269999999999999e-05d, new GammaParticle(2338440.0, 0.00053) }, { 4.6368e-06d, new GammaParticle(2821730.0, 0.00044) }, { 1.77820516d, new GammaParticle(511000.0, 0.00243) }, { 0.001521654031959389d, new GammaParticle(1035.0, 1.19791) }, { 0.014177792400196459d, new GammaParticle(8616.0, 0.1439) }, { 0.027572525087896652d, new GammaParticle(8639.0, 0.14352) }, { 0.005916019988062794d, new GammaParticle(9610.0, 0.12902) }, { 0.005916019988062794d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    