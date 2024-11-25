using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 141.93998d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium142() }, { 0.09359999999999999d, new GammaParticle(32200.0, 0.0385) }, { 0.5544d, new GammaParticle(37200.0, 0.03333) }, { 0.0216d, new GammaParticle(81500.0, 0.01521) }, { 0.0216d, new GammaParticle(83700.0, 0.01481) }, { 0.0216d, new GammaParticle(115800.0, 0.01071) }, { 0.2736d, new GammaParticle(137700.0, 0.009) }, { 0.24480000000000002d, new GammaParticle(165400.0, 0.0075) }, { 0.036000000000000004d, new GammaParticle(197600.0, 0.00627) }, { 0.09359999999999999d, new GammaParticle(219400.0, 0.00565) }, { 0.72d, new GammaParticle(302900.0, 0.00409) }, { 0.0072d, new GammaParticle(335100.0, 0.0037) }, { 0.0072d, new GammaParticle(340100.0, 0.00365) }, { 0.31183952257055997d, new GammaParticle(7118.0, 0.17418) }, { 0.1188006624024565d, new GammaParticle(43743.0, 0.02834) }, { 0.21301893921903622d, new GammaParticle(44481.0, 0.02787) }, { 0.06802433612272223d, new GammaParticle(50494.0, 0.02455) }, { 0.08564263917850727d, new GammaParticle(51040.0, 0.02429) }, { 0.01761830305578506d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    