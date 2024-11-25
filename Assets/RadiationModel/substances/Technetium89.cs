using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium89";
        public override double halfLife { get; } = 12.8d;
        public override double atomicWeight { get; } = 88.92765d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium89() }, { 1.0d, new BetaParticle(1, 6615500.0) } } },

        };
    }
}
    