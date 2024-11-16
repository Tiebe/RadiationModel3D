using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium199";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 198.97381d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2988700.0), new Platinum199() } },

        };
    }
}
    
    