
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium61";
        public override double halfLife { get; } = 0.0482d;
        public override double atomicWeight { get; } = 60.9676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium61() } },

        };
    }
}
    
    