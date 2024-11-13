
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium68 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium68";
        public override double halfLife { get; } = 4070.52d;
        public override double atomicWeight { get; } = 67.92798d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zinc68() } },

        };
    }
}
    
    