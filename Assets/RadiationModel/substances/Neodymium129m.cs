using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium129m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium129m";
        public override double halfLife { get; } = 6.7d;
        public override double atomicWeight { get; } = 128.93309d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium129() }, { 1.0d, new BetaParticle(1, 6979000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium128() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    