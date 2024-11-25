using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium169";
        public override double halfLife { get; } = 194.4d;
        public override double atomicWeight { get; } = 168.94126d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium169() }, { 1.0d, new BetaParticle(1, 2829265.0) }, { 0.015960000000000002d, new GammaParticle(68400.0, 0.01813) }, { 0.00588d, new GammaParticle(72900.0, 0.01701) }, { 0.03864d, new GammaParticle(123600.0, 0.01003) }, { 0.09744d, new GammaParticle(369500.0, 0.00336) }, { 0.84d, new GammaParticle(492860.0, 0.00252) }, { 0.3d, new GammaParticle(511000.0, 0.00243) }, { 0.192d, new GammaParticle(8810.0, 0.14073) }, { 0.203d, new GammaParticle(52965.0, 0.02341) }, { 0.35600000000000004d, new GammaParticle(54070.0, 0.02293) }, { 0.11699999999999999d, new GammaParticle(61387.0, 0.0202) }, { 0.14800000000000002d, new GammaParticle(62084.0, 0.01997) }, { 0.030899999999999997d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    