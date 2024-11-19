using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium46n : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium46n";
        public override double halfLife { get; } = 18.75d;
        public override double atomicWeight { get; } = 45.95532d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0087, 142500.0), new Scandium46() } },

        };
    }
}
    
    