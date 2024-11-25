using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium174m";
        public override double halfLife { get; } = 12268800.0d;
        public override double atomicWeight { get; } = 173.94053d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9937999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium174() }, { 0.124d, new GammaParticle(44683.0, 0.02775) }, { 0.000288d, new GammaParticle(59080.0, 0.02099) }, { 0.0725d, new GammaParticle(67058.0, 0.01849) }, { 0.00298d, new GammaParticle(111762.0, 0.01109) }, { 0.00015d, new GammaParticle(126200.0, 0.00982) }, { 0.52293127825216d, new GammaParticle(8810.0, 0.14073) }, { 0.19582364976730968d, new GammaParticle(52965.0, 0.02341) }, { 0.3439122756714255d, new GammaParticle(54070.0, 0.02293) }, { 0.11315666158327913d, new GammaParticle(61387.0, 0.0202) }, { 0.14303002024126482d, new GammaParticle(62084.0, 0.01997) }, { 0.029873358657985693d, new GammaParticle(62927.0, 0.0197) } } },
            { 0.0062d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium174() }, { 0.00064d, new GammaParticle(76468.0, 0.01621) }, { 0.004699999999999999d, new GammaParticle(176653.0, 0.00702) }, { 0.0055000000000000005d, new GammaParticle(272914.0, 0.00454) }, { 0.000157d, new GammaParticle(363640.0, 0.00341) }, { 0.000145d, new GammaParticle(628210.0, 0.00197) }, { 0.0054600000000000004d, new GammaParticle(992077.0, 0.00125) }, { 0.000165d, new GammaParticle(1264980.0, 0.00098) }, { 0.002513357502082d, new GammaParticle(8502.0, 0.14583) }, { 0.0006942195095509976d, new GammaParticle(51354.0, 0.02414) }, { 0.001223725558877133d, new GammaParticle(52389.0, 0.02367) }, { 0.0004016885746010066d, new GammaParticle(59481.0, 0.02084) }, { 0.0005065292925718693d, new GammaParticle(60151.0, 0.02061) }, { 0.00010484071797086273d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    