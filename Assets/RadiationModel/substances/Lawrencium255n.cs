using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium255n : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 255.09742d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00156), new Lawrencium255() } },

        };
    }
}
    
    