
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium52";
        public override double halfLife { get; } = 224.58d;
        public override double atomicWeight { get; } = 51.94477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium52() } },

        };
    }
}
    
    