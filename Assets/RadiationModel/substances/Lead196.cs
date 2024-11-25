using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead196 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead196";
        public override double halfLife { get; } = 2220.0d;
        public override double atomicWeight { get; } = 195.97279d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury196() }, { 1.0d, new BetaParticle(1, 3238950.0) }, { 0.00271d, new GammaParticle(113000.0, 0.01097) }, { 0.020596d, new GammaParticle(126000.0, 0.00984) }, { 0.002439d, new GammaParticle(127000.0, 0.00976) }, { 0.007859d, new GammaParticle(175000.0, 0.00708) }, { 0.11111d, new GammaParticle(191700.0, 0.00647) }, { 0.08130000000000001d, new GammaParticle(240000.0, 0.00517) }, { 0.009485d, new GammaParticle(241000.0, 0.00514) }, { 0.271d, new GammaParticle(253100.0, 0.0049) }, { 0.03794d, new GammaParticle(302200.0, 0.0041) }, { 0.11111d, new GammaParticle(366500.0, 0.00338) }, { 0.056909999999999995d, new GammaParticle(493900.0, 0.00251) }, { 0.26558d, new GammaParticle(502100.0, 0.00247) }, { 0.01355d, new GammaParticle(515200.0, 0.00241) }, { 0.01897d, new GammaParticle(701000.0, 0.00177) }, { 0.00813d, new GammaParticle(714100.0, 0.00174) }, { 0.01897d, new GammaParticle(755200.0, 0.00164) }, { 0.040650000000000006d, new GammaParticle(954100.0, 0.0013) }, { 0.005492d, new GammaParticle(511000.0, 0.00243) }, { 0.438429653392518d, new GammaParticle(12148.0, 0.10206) }, { 0.3311714057315885d, new GammaParticle(70832.0, 0.0175) }, { 0.5590334330377928d, new GammaParticle(72874.0, 0.01701) }, { 0.19012084837248933d, new GammaParticle(82629.0, 0.015) }, { 0.24658674033911865d, new GammaParticle(83631.0, 0.01483) }, { 0.056465891966629315d, new GammaParticle(84866.0, 0.01461) } } },
            { 3e-07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury192() }, { 1.0d, new AlphaParticle(5260002.09) } } },

        };
    }
}
    