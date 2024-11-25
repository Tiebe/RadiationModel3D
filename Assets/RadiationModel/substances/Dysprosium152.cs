using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium152";
        public override double halfLife { get; } = 8568.0d;
        public override double atomicWeight { get; } = 151.92473d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium152() }, { 1.0d, new BetaParticle(1, 2294650.00001) }, { 0.975d, new GammaParticle(256930.0, 0.00483) }, { 0.158220800118d, new GammaParticle(7118.0, 0.17418) }, { 0.21831357573317153d, new GammaParticle(43743.0, 0.02834) }, { 0.39145342609498207d, new GammaParticle(44481.0, 0.02787) }, { 0.12500465700702657d, new GammaParticle(50494.0, 0.02455) }, { 0.15738086317184644d, new GammaParticle(51040.0, 0.02429) }, { 0.032376206164819885d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium148() }, { 1.0d, new AlphaParticle(4748402.09) } } },

        };
    }
}
    