using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium101";
        public override double halfLife { get; } = 0.426d;
        public override double atomicWeight { get; } = 100.93016d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8106000.0), new Zirconium101() } },

        };
    }
}
    
    