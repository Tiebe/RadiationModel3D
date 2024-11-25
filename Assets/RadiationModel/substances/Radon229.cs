using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon229 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon229";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 229.04226d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium229() }, { 1.0d, new BetaParticle(-1, 1847000.0) } } },

        };
    }
}
    