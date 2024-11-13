
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur27 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur27";
        public override double halfLife { get; } = 0.0163d;
        public override double atomicWeight { get; } = 27.01878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus27() } },

        };
    }
}
    
    