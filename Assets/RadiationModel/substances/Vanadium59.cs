
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium59";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 58.95962d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium59() } },

        };
    }
}
    
    