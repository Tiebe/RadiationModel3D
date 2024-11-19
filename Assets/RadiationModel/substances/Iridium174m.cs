using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium174m";
        public override double halfLife { get; } = 4.9d;
        public override double atomicWeight { get; } = 173.96708d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new List<RadioactiveSubstance> { new BetaParticle(1, 9333000.0), new Osmium174() } },
            { 0.025d, new List<RadioactiveSubstance> { new AlphaParticle(6839002.09), new Rhenium170() } },

        };
    }
}
    
    