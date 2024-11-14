using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron71 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron71";
        public override double halfLife { get; } = 0.0343d;
        public override double atomicWeight { get; } = 70.96572d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12440000.0), new Cobalt71() } },

        };
    }
}
    
    