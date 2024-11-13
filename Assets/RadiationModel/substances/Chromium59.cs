
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium59";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 58.94835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese59() } },

        };
    }
}
    
    