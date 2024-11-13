
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium110m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium110m";
        public override double halfLife { get; } = 28.5d;
        public override double atomicWeight { get; } = 109.91131d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium110() } },

        };
    }
}
    
    