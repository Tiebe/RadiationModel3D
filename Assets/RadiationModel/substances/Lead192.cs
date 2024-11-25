using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead192 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead192";
        public override double halfLife { get; } = 210.0d;
        public override double atomicWeight { get; } = 191.97579d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999410000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury192() }, { 1.0d, new BetaParticle(1, 4729500.0) }, { 0.015d, new GammaParticle(144500.0, 0.00858) }, { 0.142d, new GammaParticle(167500.0, 0.0074) }, { 0.015d, new GammaParticle(179200.0, 0.00692) }, { 0.038d, new GammaParticle(213100.0, 0.00582) }, { 0.05d, new GammaParticle(214900.0, 0.00577) }, { 0.047d, new GammaParticle(250700.0, 0.00495) }, { 0.036000000000000004d, new GammaParticle(269500.0, 0.0046) }, { 0.083d, new GammaParticle(371000.0, 0.00334) }, { 0.032d, new GammaParticle(404500.0, 0.00307) }, { 0.064d, new GammaParticle(414100.0, 0.00299) }, { 0.18600000000000003d, new GammaParticle(608200.0, 0.00204) }, { 0.08800000000000001d, new GammaParticle(781600.0, 0.00159) }, { 0.49d, new GammaParticle(1195400.0, 0.00104) }, { 0.0782d, new GammaParticle(511000.0, 0.00243) }, { 0.36d, new GammaParticle(12148.0, 0.10206) }, { 0.27d, new GammaParticle(70832.0, 0.0175) }, { 0.45d, new GammaParticle(72874.0, 0.01701) }, { 0.153d, new GammaParticle(82629.0, 0.015) }, { 0.2d, new GammaParticle(83631.0, 0.01483) }, { 0.045d, new GammaParticle(84866.0, 0.01461) } } },
            { 5.9e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury188() }, { 1.0d, new AlphaParticle(6243002.09) } } },

        };
    }
}
    