using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead186 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead186";
        public override double halfLife { get; } = 4.81d;
        public override double atomicWeight { get; } = 185.98424d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury186() }, { 1.0d, new BetaParticle(1, 6929000.0) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury182() }, { 1.0d, new AlphaParticle(7493002.09) } } },

        };
    }
}
    