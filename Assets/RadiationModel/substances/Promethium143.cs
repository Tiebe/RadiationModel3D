using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium143";
        public override double halfLife { get; } = 22896000.0d;
        public override double atomicWeight { get; } = 142.91094d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Praseodymium143() }, { 1.0d, new BetaParticle(1, 53750.0) }, { 0.385d, new GammaParticle(741980.0, 0.00167) }, { 0.119239247176d, new GammaParticle(5870.0, 0.21122) }, { 0.21617906828293157d, new GammaParticle(36848.0, 0.03365) }, { 0.39369708301389833d, new GammaParticle(37362.0, 0.03318) }, { 0.12090782569862371d, new GammaParticle(42380.0, 0.02926) }, { 0.15198113690317d, new GammaParticle(42810.0, 0.02896) }, { 0.031073311204546292d, new GammaParticle(43335.0, 0.02861) } } },
            { 5.6999999999999994e-08d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium143() }, { 1.0d, new BetaParticle(1, 520800.0) } } },

        };
    }
}
    