using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium190";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 189.97384d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold190() }, { 1.0d, new BetaParticle(1, 4234000.0) }, { 0.000237d, new GammaParticle(292600.0, 0.00424) }, { 0.002212d, new GammaParticle(403800.0, 0.00307) }, { 0.79d, new GammaParticle(416400.0, 0.00298) }, { 0.0079d, new GammaParticle(458700.0, 0.0027) }, { 0.00553d, new GammaParticle(516800.0, 0.0024) }, { 0.0014219999999999999d, new GammaParticle(529700.0, 0.00234) }, { 0.01264d, new GammaParticle(557000.0, 0.00223) }, { 0.0079d, new GammaParticle(615300.0, 0.00202) }, { 0.1106d, new GammaParticle(625400.0, 0.00198) }, { 0.08689999999999999d, new GammaParticle(683500.0, 0.00181) }, { 0.0033179999999999998d, new GammaParticle(862200.0, 0.00144) }, { 0.003792d, new GammaParticle(933400.0, 0.00133) }, { 0.0711d, new GammaParticle(1099900.0, 0.00113) }, { 0.030019999999999998d, new GammaParticle(1142500.0, 0.00109) }, { 0.005451d, new GammaParticle(1155000.0, 0.00107) }, { 0.0023699999999999997d, new GammaParticle(1240900.0, 0.001) }, { 0.009638d, new GammaParticle(1558800.0, 0.0008) }, { 0.0079d, new GammaParticle(1558900.0, 0.0008) }, { 0.0016589999999999999d, new GammaParticle(1571200.0, 0.00079) }, { 1.5390000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.08d, new GammaParticle(11777.0, 0.10528) }, { 0.06d, new GammaParticle(68894.0, 0.018) }, { 0.11d, new GammaParticle(70820.0, 0.01751) }, { 0.04d, new GammaParticle(80316.0, 0.01544) }, { 0.05d, new GammaParticle(81285.0, 0.01525) }, { 0.011000000000000001d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    