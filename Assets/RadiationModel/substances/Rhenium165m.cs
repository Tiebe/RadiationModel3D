using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium165m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium165m";
        public override double halfLife { get; } = 1.74d;
        public override double atomicWeight { get; } = 164.96712d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new BetaParticle(1, 8229000.0), new Tungsten165() } },
            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(6744002.09), new Tantalum161() } },

        };
    }
}
    
    