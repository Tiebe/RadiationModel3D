using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium45";
        public override double halfLife { get; } = 0.547d;
        public override double atomicWeight { get; } = 44.96577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7123900.0), new Titanium45() } },

        };
    }
}
    
    