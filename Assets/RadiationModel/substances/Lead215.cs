using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead215 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead215";
        public override double halfLife { get; } = 142.0d;
        public override double atomicWeight { get; } = 215.00466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2711000.0), new Bismuth215() } },

        };
    }
}
    
    