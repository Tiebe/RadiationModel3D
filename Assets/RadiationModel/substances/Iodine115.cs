using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine115 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine115";
        public override double halfLife { get; } = 78.0d;
        public override double atomicWeight { get; } = 114.91805d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony115() }, { 1.0d, new BetaParticle(1, 5332500.0) } } },

        };
    }
}
    