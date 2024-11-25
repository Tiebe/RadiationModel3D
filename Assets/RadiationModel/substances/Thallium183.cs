using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium183";
        public override double halfLife { get; } = 6.9d;
        public override double atomicWeight { get; } = 182.98219d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold183() }, { 1.0d, new BetaParticle(1, 6802000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    