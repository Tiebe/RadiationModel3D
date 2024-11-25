using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123";
        public override double halfLife { get; } = 6.15d;
        public override double atomicWeight { get; } = 122.91044d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin123() }, { 1.0d, new BetaParticle(-1, 2192850.0) }, { 0.0019d, new GammaParticle(174180.0, 0.00712) }, { 0.0013d, new GammaParticle(175010.0, 0.00708) }, { 0.0012d, new GammaParticle(223500.0, 0.00555) }, { 0.0017000000000000001d, new GammaParticle(284700.0, 0.00435) }, { 0.0017000000000000001d, new GammaParticle(425400.0, 0.00291) }, { 0.009000000000000001d, new GammaParticle(536400.0, 0.00231) }, { 0.026000000000000002d, new GammaParticle(618800.0, 0.002) }, { 0.013000000000000001d, new GammaParticle(845500.0, 0.00147) }, { 0.003d, new GammaParticle(931200.0, 0.00133) }, { 0.004d, new GammaParticle(957300.0, 0.0013) }, { 0.32d, new GammaParticle(1019700.0, 0.00122) }, { 0.63d, new GammaParticle(1130500.0, 0.0011) }, { 0.002d, new GammaParticle(1131000.0, 0.0011) }, { 0.0004d, new GammaParticle(1155200.0, 0.00107) }, { 0.011200000000000002d, new GammaParticle(1382300.0, 0.0009) }, { 0.0027d, new GammaParticle(2001200.0, 0.00062) }, { 0.000106194665552d, new GammaParticle(3753.0, 0.33036) }, { 0.0003299749156437852d, new GammaParticle(25044.0, 0.04951) }, { 0.0006175835965633262d, new GammaParticle(25271.0, 0.04906) }, { 0.0001746294133608093d, new GammaParticle(28579.0, 0.04338) }, { 0.00020903140779288874d, new GammaParticle(28810.0, 0.04304) }, { 3.440199443207943e-05d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    