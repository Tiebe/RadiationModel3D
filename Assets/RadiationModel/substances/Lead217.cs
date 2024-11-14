using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead217 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead217";
        public override double halfLife { get; } = 19.9d;
        public override double atomicWeight { get; } = 217.01316d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3530000.0), new Bismuth217() } },

        };
    }
}
    
    