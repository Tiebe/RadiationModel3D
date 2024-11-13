
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold189m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold189m";
        public override double halfLife { get; } = 275.4d;
        public override double atomicWeight { get; } = 188.96421d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum189() } },

        };
    }
}
    
    