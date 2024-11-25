using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium198p : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium198p";
        public override double halfLife { get; } = 0.0321d;
        public override double atomicWeight { get; } = 197.97124d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium198() }, { 0.0008100000000000001d, new GammaParticle(23100.0, 0.05367) }, { 0.20600000000000002d, new GammaParticle(198800.0, 0.00624) }, { 0.062d, new GammaParticle(259500.0, 0.00478) }, { 0.0276d, new GammaParticle(260900.0, 0.00475) }, { 0.61d, new GammaParticle(282800.0, 0.00438) }, { 0.600302783736d, new GammaParticle(12148.0, 0.10206) }, { 0.211861016089542d, new GammaParticle(70832.0, 0.0175) }, { 0.3576316949519615d, new GammaParticle(72874.0, 0.01701) }, { 0.12162643096260331d, new GammaParticle(82629.0, 0.015) }, { 0.15774948095849647d, new GammaParticle(83631.0, 0.01483) }, { 0.03612304999589318d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    