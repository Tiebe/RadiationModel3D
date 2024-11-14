using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper75n : RadioactiveSubstance
    {
        public override string name { get; } = "Copper75n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 74.94159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01873), new Copper75() } },

        };
    }
}
    
    