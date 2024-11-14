using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium235 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium235";
        public override double halfLife { get; } = 432.0d;
        public override double atomicWeight { get; } = 235.04726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1729000.0), new Protactinium235() } },

        };
    }
}
    
    