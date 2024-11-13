
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium58";
        public override double halfLife { get; } = 0.191d;
        public override double atomicWeight { get; } = 57.9566d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium58() } },

        };
    }
}
    
    