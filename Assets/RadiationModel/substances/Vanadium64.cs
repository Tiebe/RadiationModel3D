
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium64";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 63.98248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium64() } },

        };
    }
}
    
    