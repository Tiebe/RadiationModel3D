using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus41 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus41";
        public override double halfLife { get; } = 0.101d;
        public override double atomicWeight { get; } = 40.99465d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur41() }, { 1.0d, new BetaParticle(-1, 7014500.0) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur41() }, { 1.0d, new BetaParticle(-1, 7014500.0) } } },

        };
    }
}
    