using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium122";
        public override double halfLife { get; } = 0.175d;
        public override double atomicWeight { get; } = 121.93063d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver122() }, { 1.0d, new BetaParticle(-1, 3247000.0) } } },
            { 0.025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver122() }, { 1.0d, new BetaParticle(-1, 3247000.0) } } },

        };
    }
}
    