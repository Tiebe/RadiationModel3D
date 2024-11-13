
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth199 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth199";
        public override double halfLife { get; } = 1620.0d;
        public override double atomicWeight { get; } = 198.97767d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead199() } },

        };
    }
}
    
    