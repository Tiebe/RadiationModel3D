using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium242";
        public override double halfLife { get; } = 1008.0d;
        public override double atomicWeight { get; } = 242.06293d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium242() }, { 1.0d, new BetaParticle(-1, 600000.0) }, { 0.03675d, new GammaParticle(55580.0, 0.02231) }, { 0.09016d, new GammaParticle(67600.0, 0.01834) }, { 0.00735d, new GammaParticle(160400.0, 0.00773) }, { 0.006860000000000001d, new GammaParticle(182000.0, 0.00681) }, { 0.00147d, new GammaParticle(220400.0, 0.00563) }, { 0.00098d, new GammaParticle(226300.0, 0.00548) }, { 0.00196d, new GammaParticle(238200.0, 0.00521) }, { 0.001078d, new GammaParticle(274200.0, 0.00452) }, { 0.003332d, new GammaParticle(304500.0, 0.00407) }, { 0.00196d, new GammaParticle(320600.0, 0.00387) }, { 0.00735d, new GammaParticle(329700.0, 0.00376) }, { 0.00196d, new GammaParticle(530600.0, 0.00234) }, { 0.01764d, new GammaParticle(572900.0, 0.00216) }, { 0.01813d, new GammaParticle(585000.0, 0.00212) }, { 0.020862745189999997d, new GammaParticle(17136.0, 0.07235) } } },

        };
    }
}
    