using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium84";
        public override double halfLife { get; } = 1548.0d;
        public override double atomicWeight { get; } = 83.92333d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2472000.0), new Yttrium84() } },

        };
    }
}
    
    