
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc71m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc71m";
        public override double halfLife { get; } = 14932.8d;
        public override double atomicWeight { get; } = 70.92789d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium71() } },

        };
    }
}
    
    