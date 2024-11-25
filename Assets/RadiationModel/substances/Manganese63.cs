using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese63 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese63";
        public override double halfLife { get; } = 0.276d;
        public override double atomicWeight { get; } = 62.94966d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron63() }, { 1.0d, new BetaParticle(-1, 4374500.0) }, { 0.064d, new GammaParticle(93800.0, 0.01322) }, { 0.0022d, new GammaParticle(229900.0, 0.00539) }, { 0.0078000000000000005d, new GammaParticle(268100.0, 0.00462) }, { 0.008100000000000001d, new GammaParticle(323700.0, 0.00383) }, { 0.49d, new GammaParticle(357200.0, 0.00347) }, { 0.016d, new GammaParticle(424400.0, 0.00292) }, { 0.07400000000000001d, new GammaParticle(451100.0, 0.00275) }, { 0.009300000000000001d, new GammaParticle(455500.0, 0.00272) }, { 0.069d, new GammaParticle(507000.0, 0.00245) }, { 0.0037d, new GammaParticle(549200.0, 0.00226) }, { 0.078d, new GammaParticle(625700.0, 0.00198) }, { 0.018000000000000002d, new GammaParticle(658600.0, 0.00188) }, { 0.018000000000000002d, new GammaParticle(681700.0, 0.00182) }, { 0.018000000000000002d, new GammaParticle(681700.0, 0.00182) }, { 0.064d, new GammaParticle(775500.0, 0.0016) }, { 0.0078000000000000005d, new GammaParticle(820800.0, 0.00151) }, { 0.0074d, new GammaParticle(908800.0, 0.00136) }, { 0.0028000000000000004d, new GammaParticle(1083400.0, 0.00114) }, { 0.17d, new GammaParticle(1132800.0, 0.00109) }, { 0.027000000000000003d, new GammaParticle(1177000.0, 0.00105) }, { 0.0098d, new GammaParticle(1542600.0, 0.0008) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    