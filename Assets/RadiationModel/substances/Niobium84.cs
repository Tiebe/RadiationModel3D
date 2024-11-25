using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium84";
        public override double halfLife { get; } = 9.8d;
        public override double atomicWeight { get; } = 83.93431d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium84() }, { 1.0d, new BetaParticle(1, 6350100.0) }, { 0.06726d, new GammaParticle(456200.0, 0.00272) }, { 0.885d, new GammaParticle(540000.0, 0.0023) }, { 0.3009d, new GammaParticle(579400.0, 0.00214) }, { 0.04425d, new GammaParticle(704000.0, 0.00176) }, { 0.059295d, new GammaParticle(723000.0, 0.00171) }, { 0.053985000000000005d, new GammaParticle(1036400.0, 0.0012) }, { 0.11505000000000001d, new GammaParticle(1119600.0, 0.00111) }, { 0.08230499999999999d, new GammaParticle(1426700.0, 0.00087) }, { 2.05d, new GammaParticle(511000.0, 0.00243) }, { 0.000237d, new GammaParticle(2161.0, 0.57374) }, { 0.00134d, new GammaParticle(15691.0, 0.07902) }, { 0.00256d, new GammaParticle(15775.0, 0.0786) }, { 0.00065d, new GammaParticle(17736.0, 0.06991) }, { 0.00075d, new GammaParticle(17824.0, 0.06956) }, { 9.499999999999999e-05d, new GammaParticle(17968.0, 0.069) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    