using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium75";
        public override double halfLife { get; } = 4966.8d;
        public override double atomicWeight { get; } = 74.92286d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic75() }, { 1.0d, new BetaParticle(-1, 588615.0) }, { 0.00114d, new GammaParticle(66000.0, 0.01879) }, { 7.98e-06d, new GammaParticle(136000.0, 0.00912) }, { 0.011856d, new GammaParticle(198600.0, 0.00624) }, { 1.14e-05d, new GammaParticle(204260.0, 0.00607) }, { 0.114d, new GammaParticle(264600.0, 0.00469) }, { 3.42e-05d, new GammaParticle(270200.0, 0.00459) }, { 5.7e-05d, new GammaParticle(279700.0, 0.00443) }, { 4.56e-05d, new GammaParticle(338000.0, 0.00367) }, { 0.0002052d, new GammaParticle(353000.0, 0.00351) }, { 0.0018468d, new GammaParticle(419100.0, 0.00296) }, { 0.0022344d, new GammaParticle(468800.0, 0.00264) }, { 0.00114d, new GammaParticle(617700.0, 0.00201) }, { 2.6099999999999997e-05d, new GammaParticle(1320.0, 0.93927) }, { 0.000212d, new GammaParticle(10509.0, 0.11798) }, { 0.00041d, new GammaParticle(10544.0, 0.11759) }, { 9.400000000000001e-05d, new GammaParticle(11773.0, 0.10531) }, { 9.8e-05d, new GammaParticle(11791.0, 0.10515) }, { 3.6000000000000003e-06d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    