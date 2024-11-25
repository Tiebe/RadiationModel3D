using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon32";
        public override double halfLife { get; } = 4954437378.01094d;
        public override double atomicWeight { get; } = 31.97415d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus32() }, { 1.0d, new BetaParticle(-1, 113595.0) } } },

        };
    }
}
    