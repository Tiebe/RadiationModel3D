using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum186 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum186";
        public override double halfLife { get; } = 7560.0d;
        public override double atomicWeight { get; } = 185.95935d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium186() }, { 1.0d, new BetaParticle(1, 2568000.0) } } },
            { 1.4e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium182() }, { 1.0d, new AlphaParticle(5342002.09) } } },

        };
    }
}
    