using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus37 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus37";
        public override double halfLife { get; } = 2.31d;
        public override double atomicWeight { get; } = 36.9796d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur37() }, { 1.0d, new BetaParticle(-1, 3948215.0) } } },

        };
    }
}
    