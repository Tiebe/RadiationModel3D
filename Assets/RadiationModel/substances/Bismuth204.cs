using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth204 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204";
        public override double halfLife { get; } = 40392.0d;
        public override double atomicWeight { get; } = 203.97784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4463800.0), new Lead204() } },

        };
    }
}
    
    