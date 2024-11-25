using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum167 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum167";
        public override double halfLife { get; } = 80.0d;
        public override double atomicWeight { get; } = 166.94809d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium167() }, { 1.0d, new BetaParticle(1, 4589500.0) } } },

        };
    }
}
    