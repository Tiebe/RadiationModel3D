using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium156m";
        public override double halfLife { get; } = 19080.0d;
        public override double atomicWeight { get; } = 155.92485d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium156() }, { 0.0115d, new GammaParticle(88400.0, 0.01403) }, { 0.07d, new GammaParticle(7118.0, 0.17418) }, { 0.008d, new GammaParticle(43743.0, 0.02834) }, { 0.013999999999999999d, new GammaParticle(44481.0, 0.02787) }, { 0.005d, new GammaParticle(50494.0, 0.02455) }, { 0.006d, new GammaParticle(51040.0, 0.02429) }, { 0.0012d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium156() }, { 1.0d, new BetaParticle(1, 40000.0) } } },

        };
    }
}
    