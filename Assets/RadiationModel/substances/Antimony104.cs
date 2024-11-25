using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony104 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony104";
        public override double halfLife { get; } = 0.44d;
        public override double atomicWeight { get; } = 103.93634d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium104() }, { 1.0d, new BetaParticle(1, 8441500.0) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium103() }, { 1.0d, new ProtonParticle() } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin103() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    