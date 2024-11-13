
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead218 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead218";
        public override double halfLife { get; } = 14.8d;
        public override double atomicWeight { get; } = 218.01678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth218() } },

        };
    }
}
    
    