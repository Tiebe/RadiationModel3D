using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel63 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel63";
        public override double halfLife { get; } = 3180938138.23887d;
        public override double atomicWeight { get; } = 62.92967d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper63() }, { 1.0d, new BetaParticle(-1, 33500.0) } } },

        };
    }
}
    