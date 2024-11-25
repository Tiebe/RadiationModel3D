using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium145m";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 144.9376d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium145() }, { 1.0d, new BetaParticle(1, 7401000.0) }, { 0.13d, new GammaParticle(578200.0, 0.00214) }, { 0.1209d, new GammaParticle(639600.0, 0.00194) }, { 0.1001d, new GammaParticle(804300.0, 0.00154) }, { 1.82d, new GammaParticle(511000.0, 0.00243) }, { 0.014336206680000001d, new GammaParticle(7118.0, 0.17418) }, { 0.02063189266556502d, new GammaParticle(43743.0, 0.02834) }, { 0.03699460761263227d, new GammaParticle(44481.0, 0.02787) }, { 0.011813661415252362d, new GammaParticle(50494.0, 0.02455) }, { 0.01487339972180272d, new GammaParticle(51040.0, 0.02429) }, { 0.0030597383065503613d, new GammaParticle(51699.0, 0.02398) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium144() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    