using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium91n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 90.90917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00061, 2034400.0), new Niobium91() } },

        };
    }
}
    
    