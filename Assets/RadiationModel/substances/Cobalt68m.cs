using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt68m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt68m";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 67.94472d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11973800.0), new Nickel68() } },

        };
    }
}
    
    