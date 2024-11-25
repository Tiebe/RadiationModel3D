using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron14 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron14";
        public override double halfLife { get; } = 0.0125d;
        public override double atomicWeight { get; } = 14.0254d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon14() }, { 1.0d, new BetaParticle(-1, 10322053.5) } } },
            { 0.061d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon14() }, { 1.0d, new BetaParticle(-1, 10322053.5) } } },

        };
    }
}
    