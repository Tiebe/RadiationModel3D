using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury189 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury189";
        public override double halfLife { get; } = 456.0d;
        public override double atomicWeight { get; } = 188.96819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3952000.0), new Gold189() } },

        };
    }
}
    
    