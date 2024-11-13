
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum185m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum185m";
        public override double halfLife { get; } = 1980.0d;
        public override double atomicWeight { get; } = 184.96072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iridium185() } },

        };
    }
}
    
    