
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper74 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper74";
        public override double halfLife { get; } = 1.606d;
        public override double atomicWeight { get; } = 73.93988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc74() } },

        };
    }
}
    
    