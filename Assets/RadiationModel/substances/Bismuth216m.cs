
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth216m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth216m";
        public override double halfLife { get; } = 396.0d;
        public override double atomicWeight { get; } = 216.00633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium216() } },

        };
    }
}
    
    