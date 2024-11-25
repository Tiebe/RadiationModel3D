using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium189";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 188.97357d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold189() }, { 1.0d, new BetaParticle(1, 4483000.0) } } },

        };
    }
}
    