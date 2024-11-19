using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium243m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium243m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 243.06241d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00323, 383600.0), new Plutonium243() } },

        };
    }
}
    
    