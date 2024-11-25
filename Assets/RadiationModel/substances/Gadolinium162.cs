using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium162";
        public override double halfLife { get; } = 504.0d;
        public override double atomicWeight { get; } = 161.93099d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium162() }, { 1.0d, new BetaParticle(-1, 799250.0) }, { 0.051d, new GammaParticle(39000.0, 0.03179) }, { 0.0159d, new GammaParticle(302300.0, 0.0041) }, { 0.027000000000000003d, new GammaParticle(341420.0, 0.00363) }, { 0.44d, new GammaParticle(403000.0, 0.00308) }, { 0.51d, new GammaParticle(442120.0, 0.0028) }, { 0.0010707565044d, new GammaParticle(7118.0, 0.17418) }, { 0.0015560927867778866d, new GammaParticle(43743.0, 0.02834) }, { 0.0027901968563347436d, new GammaParticle(44481.0, 0.02787) }, { 0.000891006637718324d, new GammaParticle(50494.0, 0.02455) }, { 0.00112177735688737d, new GammaParticle(51040.0, 0.02429) }, { 0.00023077071916904592d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    