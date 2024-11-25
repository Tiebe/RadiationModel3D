using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium183";
        public override double halfLife { get; } = 3664.8d;
        public override double atomicWeight { get; } = 182.95354d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum183() }, { 1.0d, new BetaParticle(-1, 1006750.0) }, { 0.38d, new GammaParticle(73160.0, 0.01695) }, { 0.0003d, new GammaParticle(84690.0, 0.01464) }, { 0.0014000000000000002d, new GammaParticle(113720.0, 0.0109) }, { 0.00025d, new GammaParticle(124100.0, 0.00999) }, { 0.00017999999999999998d, new GammaParticle(131000.0, 0.00946) }, { 0.00025d, new GammaParticle(139000.0, 0.00892) }, { 0.004699999999999999d, new GammaParticle(143190.0, 0.00866) }, { 0.00018999999999999998d, new GammaParticle(149100.0, 0.00832) }, { 0.00034d, new GammaParticle(153750.0, 0.00806) }, { 0.00033d, new GammaParticle(157900.0, 0.00785) }, { 0.0052d, new GammaParticle(160780.0, 0.00771) }, { 0.00035999999999999997d, new GammaParticle(165200.0, 0.00751) }, { 0.00031d, new GammaParticle(180400.0, 0.00687) }, { 0.0008d, new GammaParticle(223400.0, 0.00555) }, { 0.0015d, new GammaParticle(225000.0, 0.00551) }, { 0.0036d, new GammaParticle(284100.0, 0.00436) }, { 0.0017000000000000001d, new GammaParticle(295210.0, 0.0042) }, { 0.012199999999999999d, new GammaParticle(315855.0, 0.00393) }, { 0.0008799999999999999d, new GammaParticle(375780.0, 0.0033) }, { 0.028999999999999998d, new GammaParticle(397860.0, 0.00312) }, { 0.298d, new GammaParticle(459073.0, 0.0027) }, { 0.0009d, new GammaParticle(466700.0, 0.00266) }, { 0.0016d, new GammaParticle(471100.0, 0.00263) }, { 0.0072d, new GammaParticle(476900.0, 0.0026) }, { 0.006999999999999999d, new GammaParticle(481310.0, 0.00258) }, { 0.0008d, new GammaParticle(500700.0, 0.00248) }, { 0.0015d, new GammaParticle(536800.0, 0.00231) }, { 0.0021d, new GammaParticle(594800.0, 0.00208) }, { 0.0024d, new GammaParticle(686500.0, 0.00181) }, { 0.003d, new GammaParticle(691730.0, 0.00179) }, { 0.00043999999999999996d, new GammaParticle(715300.0, 0.00173) }, { 0.0007000000000000001d, new GammaParticle(717200.0, 0.00173) }, { 0.0006d, new GammaParticle(727300.0, 0.0017) }, { 0.0088d, new GammaParticle(735050.0, 0.00169) }, { 0.0007000000000000001d, new GammaParticle(762900.0, 0.00163) }, { 0.0014000000000000002d, new GammaParticle(769300.0, 0.00161) }, { 0.655d, new GammaParticle(783730.0, 0.00158) }, { 0.0002d, new GammaParticle(797200.0, 0.00156) }, { 0.0014000000000000002d, new GammaParticle(806500.0, 0.00154) }, { 0.0011d, new GammaParticle(856780.0, 0.00145) }, { 0.0004d, new GammaParticle(868500.0, 0.00143) }, { 0.0006d, new GammaParticle(875500.0, 0.00142) }, { 0.00026d, new GammaParticle(959600.0, 0.00129) }, { 0.0004d, new GammaParticle(987100.0, 0.00126) }, { 0.0007000000000000001d, new GammaParticle(1045500.0, 0.00119) }, { 0.0004d, new GammaParticle(1112700.0, 0.00111) }, { 0.027000000000000003d, new GammaParticle(1470200.0, 0.00084) }, { 0.0002d, new GammaParticle(1543000.0, 0.0008) }, { 0.0007000000000000001d, new GammaParticle(1784300.0, 0.00069) }, { 0.07459467792768d, new GammaParticle(9424.0, 0.13156) }, { 0.07422146940720788d, new GammaParticle(56280.0, 0.02203) }, { 0.12939586716737775d, new GammaParticle(57535.0, 0.02155) }, { 0.042807739264105804d, new GammaParticle(65315.0, 0.01898) }, { 0.05436582886541437d, new GammaParticle(66067.0, 0.01877) }, { 0.011558089601308566d, new GammaParticle(66981.0, 0.01851) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium183() } } },

        };
    }
}
    