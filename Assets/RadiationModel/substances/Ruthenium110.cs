using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium110";
        public override double halfLife { get; } = 12.04d;
        public override double atomicWeight { get; } = 109.91404d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2756000.0), new Rhodium110() } },

        };
    }
}
    
    