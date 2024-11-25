using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth216 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth216";
        public override double halfLife { get; } = 135.0d;
        public override double atomicWeight { get; } = 216.00631d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium216() }, { 1.0d, new BetaParticle(-1, 2045849.99999) } } },

        };
    }
}
    