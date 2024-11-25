using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton95 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95";
        public override double halfLife { get; } = 0.114d;
        public override double atomicWeight { get; } = 94.93971d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium95() }, { 1.0d, new BetaParticle(-1, 4865500.0) } } },
            { 0.0287d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rubidium95() }, { 1.0d, new BetaParticle(-1, 4865500.0) } } },

        };
    }
}
    