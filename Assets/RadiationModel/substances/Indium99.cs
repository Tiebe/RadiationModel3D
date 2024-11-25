using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium99";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 98.93411d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.009000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver98() }, { 1.0d, new BetaParticle(1, 471592051.736) }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    