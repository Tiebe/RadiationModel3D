using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt68 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt68";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 67.94456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11820800.0), new Nickel68() } },

        };
    }
}
    
    