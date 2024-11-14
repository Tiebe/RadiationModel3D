using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic64 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic64";
        public override double halfLife { get; } = 0.069d;
        public override double atomicWeight { get; } = 63.95756d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14786000.0), new Germanium64() } },

        };
    }
}
    
    