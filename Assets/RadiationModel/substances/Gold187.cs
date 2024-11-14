using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold187 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold187";
        public override double halfLife { get; } = 498.0d;
        public override double atomicWeight { get; } = 186.96454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3656000.0), new Platinum187() } },

        };
    }
}
    
    