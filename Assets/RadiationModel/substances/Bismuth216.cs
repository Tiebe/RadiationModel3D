using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth216 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth216";
        public override double halfLife { get; } = 132.6d;
        public override double atomicWeight { get; } = 216.00631d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4091700.0), new Polonium216() } },

        };
    }
}
    
    