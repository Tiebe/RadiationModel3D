using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc73 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc73";
        public override double halfLife { get; } = 24.5d;
        public override double atomicWeight { get; } = 72.92958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4105899.9999999995), new Gallium73() } },

        };
    }
}
    
    