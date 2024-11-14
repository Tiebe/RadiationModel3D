using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth203 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth203";
        public override double halfLife { get; } = 42336.0d;
        public override double atomicWeight { get; } = 202.97689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3261000.0), new Lead203() } },

        };
    }
}
    
    