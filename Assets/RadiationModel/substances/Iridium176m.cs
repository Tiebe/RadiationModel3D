using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium176m";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 175.96368d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9690000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium176() }, { 1.0d, new BetaParticle(1, 5616500.0) } } },
            { 0.031d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium172() }, { 1.0d, new AlphaParticle(6337002.09) } } },

        };
    }
}
    