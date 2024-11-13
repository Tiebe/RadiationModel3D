
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold199 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold199";
        public override double halfLife { get; } = 271209.6d;
        public override double atomicWeight { get; } = 198.96877d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Mercury199() } },

        };
    }
}
    
    