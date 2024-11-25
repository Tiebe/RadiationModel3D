using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead191 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead191";
        public override double halfLife { get; } = 79.8d;
        public override double atomicWeight { get; } = 190.97822d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998699999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury191() }, { 1.0d, new BetaParticle(1, 5150500.0) } } },
            { 0.00013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury187() }, { 1.0d, new AlphaParticle(6425002.09) } } },

        };
    }
}
    