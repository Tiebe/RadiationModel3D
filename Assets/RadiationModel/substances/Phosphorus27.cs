
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus27 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus27";
        public override double halfLife { get; } = 0.26d;
        public override double atomicWeight { get; } = 26.99929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon27() } },

        };
    }
}
    
    