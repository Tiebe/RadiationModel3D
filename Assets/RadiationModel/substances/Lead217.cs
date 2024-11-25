using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead217 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead217";
        public override double halfLife { get; } = 19.9d;
        public override double atomicWeight { get; } = 217.01316d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth217() }, { 1.0d, new BetaParticle(-1, 1765000.0) } } },

        };
    }
}
    