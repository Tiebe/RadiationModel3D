
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium194";
        public override double halfLife { get; } = 69660.0d;
        public override double atomicWeight { get; } = 193.96508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum194() } },

        };
    }
}
    
    