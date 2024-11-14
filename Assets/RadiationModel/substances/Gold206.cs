using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold206 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold206";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 205.98477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6756000.0), new Mercury206() } },

        };
    }
}
    
    