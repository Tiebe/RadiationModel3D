
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc71 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc71";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 70.92772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium71() } },

        };
    }
}
    
    