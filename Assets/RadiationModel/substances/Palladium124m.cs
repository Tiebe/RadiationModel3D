using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium124m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium124m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 123.93838d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1000000.0, 0.00124)), new Palladium124() } },

        };
    }
}
    
    