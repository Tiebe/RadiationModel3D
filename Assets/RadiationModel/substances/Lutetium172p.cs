using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172p";
        public override double halfLife { get; } = 0.00044d;
        public override double atomicWeight { get; } = 171.93921d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium172() }, { 3.9e-05d, new GammaParticle(41860.0, 0.02962) }, { 0.504d, new GammaParticle(67350.0, 0.01841) }, { 0.28017552d, new GammaParticle(8810.0, 0.14073) }, { 0.10974380779442411d, new GammaParticle(52965.0, 0.02341) }, { 0.19273587600004233d, new GammaParticle(54070.0, 0.02293) }, { 0.06341544003602342d, new GammaParticle(61387.0, 0.0202) }, { 0.08015711620553362d, new GammaParticle(62084.0, 0.01997) }, { 0.01674167616951018d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    