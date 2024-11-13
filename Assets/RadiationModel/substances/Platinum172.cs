
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum172 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum172";
        public override double halfLife { get; } = 0.0976d;
        public override double atomicWeight { get; } = 171.97734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.96d, new List<RadioactiveSubstance> { new AlphaParticle(), new Osmium168() } },

        };
    }
}
    
    