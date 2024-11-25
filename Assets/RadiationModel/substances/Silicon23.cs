using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon23 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon23";
        public override double halfLife { get; } = 0.0423d;
        public override double atomicWeight { get; } = 23.02571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium23() }, { 1.0d, new BetaParticle(1, 14711835.0) } } },
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium22() }, { 1.0d, new ProtonParticle() } } },
            { 0.036000000000000004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sodium21() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    