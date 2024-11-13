
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron45 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron45";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 45.01547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.7d, new List<RadioactiveSubstance> { new ProtonParticle(), new Chromium43() } },

            { 0.3d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese45() } },

        };
    }
}
    
    