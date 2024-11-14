using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium95m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93016d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00148), new Rubidium95() } },

        };
    }
}
    
    