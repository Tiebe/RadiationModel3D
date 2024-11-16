using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium195";
        public override double halfLife { get; } = 8244.0d;
        public override double atomicWeight { get; } = 194.96598d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1101600.0), new Platinum195() } },

        };
    }
}
    
    