using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine34m : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine34m";
        public override double halfLife { get; } = 1919.4d;
        public override double atomicWeight { get; } = 33.97392d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5539999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus34() }, { 1.0d, new BetaParticle(1, 127485.0) }, { 0.1409d, new GammaParticle(1176650.0, 0.00105) }, { 0.00016d, new GammaParticle(1572570.0, 0.00079) }, { 0.00185d, new GammaParticle(1987190.0, 0.00062) }, { 0.428d, new GammaParticle(2127499.0, 0.00058) }, { 0.00033d, new GammaParticle(2561360.0, 0.00048) }, { 0.00021999999999999998d, new GammaParticle(2749240.0, 0.00045) }, { 0.1229d, new GammaParticle(3304031.0, 0.00038) }, { 0.0027300000000000002d, new GammaParticle(4114520.0, 0.0003) }, { 1.08528d, new GammaParticle(511000.0, 0.00243) }, { 1.9488023628340814e-05d, new GammaParticle(185.0, 6.70185) }, { 0.0002800987160868488d, new GammaParticle(2306.0, 0.53766) }, { 0.0005543216229702133d, new GammaParticle(2308.0, 0.53719) }, { 5.173406102153785e-05d, new GammaParticle(2466.0, 0.50277) }, { 5.173406102153785e-05d, new GammaParticle(2466.0, 0.50277) } } },
            { 0.446d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine34() }, { 0.38299999999999995d, new GammaParticle(146360.0, 0.00847) }, { 0.000125626304128d, new GammaParticle(223.0, 5.55983) }, { 0.0017709834009898956d, new GammaParticle(2621.0, 0.47304) }, { 0.003502736157021154d, new GammaParticle(2623.0, 0.47268) }, { 0.0004535398819889503d, new GammaParticle(2816.0, 0.44028) }, { 0.0004535398819889503d, new GammaParticle(2816.0, 0.44028) } } },

        };
    }
}
    