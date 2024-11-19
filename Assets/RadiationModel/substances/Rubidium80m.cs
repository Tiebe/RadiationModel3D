using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium80m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium80m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 79.92305d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00251, 493900.0), new Rubidium80() } },

        };
    }
}
    
    