using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium83";
        public override double halfLife { get; } = 1.85d;
        public override double atomicWeight { get; } = 82.93454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8692900.0), new Arsenic83() } },

        };
    }
}
    
    