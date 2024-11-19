using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium45m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium45m";
        public override double halfLife { get; } = 0.318d;
        public override double atomicWeight { get; } = 44.95592d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.09999, 12400.0), new Scandium45() } },

        };
    }
}
    
    