using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc72 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc72";
        public override double halfLife { get; } = 167400.0d;
        public override double atomicWeight { get; } = 71.92684d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 442800.0), new Gallium72() } },

        };
    }
}
    
    