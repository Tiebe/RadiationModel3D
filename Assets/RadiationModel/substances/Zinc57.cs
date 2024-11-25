using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc57 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc57";
        public override double halfLife { get; } = 0.04d;
        public override double atomicWeight { get; } = 56.96506d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel57() }, { 1.0d, new BetaParticle(1, 11767000.0) }, { 1.3d, new GammaParticle(511000.0, 0.00243) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel56() }, { 1.0d, new BetaParticle(1, 476425851.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    