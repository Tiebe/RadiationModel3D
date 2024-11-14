using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc77 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc77";
        public override double halfLife { get; } = 2.08d;
        public override double atomicWeight { get; } = 76.93689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7203200.0), new Gallium77() } },

        };
    }
}
    
    