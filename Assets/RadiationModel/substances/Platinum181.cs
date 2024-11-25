using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum181 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum181";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 180.96309d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium181() }, { 1.0d, new BetaParticle(1, 4584500.0) } } },
            { 0.0008d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium177() }, { 1.0d, new AlphaParticle(6172002.09) } } },

        };
    }
}
    