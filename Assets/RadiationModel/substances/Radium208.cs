using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium208";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 208.00186d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon204() }, { 1.0d, new AlphaParticle(8295002.09) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon208() }, { 1.0d, new BetaParticle(1, 5691500.0) } } },

        };
    }
}
    