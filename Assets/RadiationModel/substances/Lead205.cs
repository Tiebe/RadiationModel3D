using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead205 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead205";
        public override double halfLife { get; } = 536467741568064.0d;
        public override double atomicWeight { get; } = 204.97448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium205() }, { 0.2199064d, new GammaParticle(12148.0, 0.10206) } } },

        };
    }
}
    