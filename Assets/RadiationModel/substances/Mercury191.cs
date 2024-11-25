using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury191 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury191";
        public override double halfLife { get; } = 2940.0d;
        public override double atomicWeight { get; } = 190.96716d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum191() }, { 1.0d, new BetaParticle(1, 2553000.0) } } },

        };
    }
}
    