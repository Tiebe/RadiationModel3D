using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium120";
        public override double halfLife { get; } = 24.0d;
        public override double atomicWeight { get; } = 119.92604d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon120() }, { 1.0d, new BetaParticle(1, 6641000.0) }, { 0.047d, new GammaParticle(75200.0, 0.01649) }, { 0.042300000000000004d, new GammaParticle(76900.0, 0.01612) }, { 0.042300000000000004d, new GammaParticle(102600.0, 0.01208) }, { 0.0282d, new GammaParticle(122100.0, 0.01015) }, { 0.0329d, new GammaParticle(126400.0, 0.00981) }, { 0.0235d, new GammaParticle(134800.0, 0.0092) }, { 0.17859999999999998d, new GammaParticle(139700.0, 0.00888) }, { 0.018799999999999997d, new GammaParticle(146000.0, 0.00849) }, { 0.0658d, new GammaParticle(152400.0, 0.00814) }, { 0.1081d, new GammaParticle(165700.0, 0.00748) }, { 0.47d, new GammaParticle(179400.0, 0.00691) }, { 0.0329d, new GammaParticle(182600.0, 0.00679) }, { 0.0799d, new GammaParticle(192800.0, 0.00643) }, { 0.047d, new GammaParticle(234300.0, 0.00529) }, { 0.0658d, new GammaParticle(248900.0, 0.00498) }, { 0.2021d, new GammaParticle(269900.0, 0.00459) }, { 2.23d, new GammaParticle(511000.0, 0.00243) }, { 0.017d, new GammaParticle(4749.0, 0.26107) }, { 0.039d, new GammaParticle(30625.0, 0.04048) }, { 0.073d, new GammaParticle(30973.0, 0.04003) }, { 0.021d, new GammaParticle(35089.0, 0.03533) }, { 0.026000000000000002d, new GammaParticle(35414.0, 0.03501) }, { 0.0052d, new GammaParticle(35818.0, 0.03462) } } },

        };
    }
}
    