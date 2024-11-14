using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic71 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic71";
        public override double halfLife { get; } = 235080.0d;
        public override double atomicWeight { get; } = 70.92711d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2013700.0), new Germanium71() } },

        };
    }
}
    
    