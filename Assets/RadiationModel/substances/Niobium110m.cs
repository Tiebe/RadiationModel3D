using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium110m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium110m";
        public override double halfLife { get; } = 0.094d;
        public override double atomicWeight { get; } = 109.94395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12326000.0), new Molybdenum110() } },

        };
    }
}
    
    