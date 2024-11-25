using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium81";
        public override double halfLife { get; } = 70.4d;
        public override double atomicWeight { get; } = 80.92945d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium81() }, { 1.0d, new BetaParticle(1, 4872000.0) }, { 0.021d, new GammaParticle(9820.0, 0.12626) }, { 0.24738d, new GammaParticle(79230.0, 0.01565) }, { 0.027528d, new GammaParticle(101050.0, 0.01227) }, { 0.042408d, new GammaParticle(114340.0, 0.01084) }, { 0.021204d, new GammaParticle(115390.0, 0.01074) }, { 0.07998d, new GammaParticle(119760.0, 0.01035) }, { 0.411804d, new GammaParticle(124160.0, 0.00999) }, { 0.03162d, new GammaParticle(155200.0, 0.00799) }, { 0.008184d, new GammaParticle(216600.0, 0.00572) }, { 0.033479999999999996d, new GammaParticle(221000.0, 0.00561) }, { 0.15326399999999998d, new GammaParticle(408180.0, 0.00304) }, { 2.6860000000000004d, new GammaParticle(511000.0, 0.00243) }, { 0.023d, new GammaParticle(1890.0, 0.656) }, { 0.109d, new GammaParticle(14098.0, 0.08794) }, { 0.209d, new GammaParticle(14165.0, 0.08753) }, { 0.051500000000000004d, new GammaParticle(15898.0, 0.07799) }, { 0.0582d, new GammaParticle(15955.0, 0.07771) }, { 0.0067d, new GammaParticle(16085.0, 0.07708) } } },

        };
    }
}
    