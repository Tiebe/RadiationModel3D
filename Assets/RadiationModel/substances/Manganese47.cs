
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese47 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese47";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 46.97577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium47() } },

        };
    }
}
    
    