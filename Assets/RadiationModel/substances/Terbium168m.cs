using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium168m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 167.94356d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((211000.0, 0.00588)), new Terbium168() } },

        };
    }
}
    
    