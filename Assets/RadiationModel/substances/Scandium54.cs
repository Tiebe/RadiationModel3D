using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium54";
        public override double halfLife { get; } = 0.526d;
        public override double atomicWeight { get; } = 53.96303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11306000.0), new Titanium54() } },

        };
    }
}
    
    