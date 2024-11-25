using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton73 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton73";
        public override double halfLife { get; } = 27.3d;
        public override double atomicWeight { get; } = 72.93929d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium73() }, { 1.0d, new BetaParticle(1, 5837500.0) }, { 0.0027d, new GammaParticle(26900.0, 0.04609) }, { 0.013000000000000001d, new GammaParticle(45600.0, 0.02719) }, { 0.033d, new GammaParticle(62400.0, 0.01987) }, { 0.006d, new GammaParticle(108000.0, 0.01148) }, { 0.055999999999999994d, new GammaParticle(151200.0, 0.0082) }, { 0.24d, new GammaParticle(178000.0, 0.00697) }, { 0.004d, new GammaParticle(183100.0, 0.00677) }, { 0.028999999999999998d, new GammaParticle(213300.0, 0.00581) }, { 0.033d, new GammaParticle(241000.0, 0.00514) }, { 0.0028000000000000004d, new GammaParticle(259000.0, 0.00479) }, { 0.0043d, new GammaParticle(286800.0, 0.00432) }, { 0.023d, new GammaParticle(303400.0, 0.00409) }, { 0.018000000000000002d, new GammaParticle(391900.0, 0.00316) }, { 0.018000000000000002d, new GammaParticle(396400.0, 0.00313) }, { 0.016d, new GammaParticle(423400.0, 0.00293) }, { 0.011000000000000001d, new GammaParticle(446400.0, 0.00278) }, { 0.043d, new GammaParticle(454300.0, 0.00273) }, { 0.027000000000000003d, new GammaParticle(457200.0, 0.00271) }, { 0.040999999999999995d, new GammaParticle(473400.0, 0.00262) }, { 0.018000000000000002d, new GammaParticle(503000.0, 0.00246) }, { 0.0068000000000000005d, new GammaParticle(608500.0, 0.00204) }, { 0.031d, new GammaParticle(635100.0, 0.00195) }, { 0.0023d, new GammaParticle(654200.0, 0.0019) }, { 0.0048d, new GammaParticle(656200.0, 0.00189) }, { 0.031d, new GammaParticle(686100.0, 0.00181) }, { 0.003d, new GammaParticle(713400.0, 0.00174) }, { 0.0063d, new GammaParticle(718300.0, 0.00173) }, { 0.0086d, new GammaParticle(907000.0, 0.00137) }, { 0.022000000000000002d, new GammaParticle(959600.0, 0.00129) }, { 0.012d, new GammaParticle(1110600.0, 0.00112) }, { 0.0033d, new GammaParticle(1295200.0, 0.00096) }, { 0.008100000000000001d, new GammaParticle(1364400.0, 0.00091) }, { 0.005600000000000001d, new GammaParticle(1445700.0, 0.00086) }, { 0.0046d, new GammaParticle(1672900.0, 0.00074) }, { 0.0043d, new GammaParticle(1975700.0, 0.00063) }, { 0.0053d, new GammaParticle(2073800.0, 0.0006) }, { 0.0076d, new GammaParticle(2083100.0, 0.0006) }, { 0.004d, new GammaParticle(2126900.0, 0.00058) }, { 0.0015d, new GammaParticle(2262000.0, 0.00055) }, { 0.0051d, new GammaParticle(2303700.0, 0.00054) }, { 0.0025d, new GammaParticle(2527900.0, 0.00049) }, { 0.0066d, new GammaParticle(2537000.0, 0.00049) }, { 0.0023d, new GammaParticle(2770800.0, 0.00045) }, { 0.013000000000000001d, new GammaParticle(2838600.0, 0.00044) }, { 0.0034999999999999996d, new GammaParticle(3107000.0, 0.0004) }, { 0.0033d, new GammaParticle(3284400.0, 0.00038) }, { 0.0025d, new GammaParticle(3291000.0, 0.00038) }, { 0.0018d, new GammaParticle(3434900.0, 0.00036) }, { 2.10731178d, new GammaParticle(511000.0, 0.00243) }, { 0.006999999999999999d, new GammaParticle(1535.0, 0.80771) }, { 0.042d, new GammaParticle(11879.0, 0.10437) }, { 0.08d, new GammaParticle(11925.0, 0.10397) }, { 0.019d, new GammaParticle(13345.0, 0.09291) }, { 0.021d, new GammaParticle(13377.0, 0.09268) }, { 0.0015d, new GammaParticle(13469.0, 0.09205) } } },
            { 0.0025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium72() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    