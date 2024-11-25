using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium175";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 174.96415d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9915d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium175() }, { 1.0d, new BetaParticle(1, 5946500.0) } } },
            { 0.0085d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium171() }, { 1.0d, new AlphaParticle(6452002.09) } } },

        };
    }
}
    