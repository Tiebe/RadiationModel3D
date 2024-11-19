using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium74m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium74m";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 73.92701d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new GammaParticle((59599.99999, 0.0208)), new Gallium74() } },

        };
    }
}
    
    