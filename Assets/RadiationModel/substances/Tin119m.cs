using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin119m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin119m";
        public override double halfLife { get; } = 25323840.0d;
        public override double atomicWeight { get; } = 118.90341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01385, 89500.0), new Tin119() } },

        };
    }
}
    
    