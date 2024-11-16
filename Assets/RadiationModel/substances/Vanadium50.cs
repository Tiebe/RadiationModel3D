using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium50";
        public override double halfLife { get; } = 8.551933992e+24d;
        public override double atomicWeight { get; } = 49.94716d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2208630.0), new Titanium50() } },

        };
    }
}
    
    