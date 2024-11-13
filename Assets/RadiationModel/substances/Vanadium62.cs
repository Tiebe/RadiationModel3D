
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium62";
        public override double halfLife { get; } = 0.0336d;
        public override double atomicWeight { get; } = 61.97294d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium62() } },

        };
    }
}
    
    