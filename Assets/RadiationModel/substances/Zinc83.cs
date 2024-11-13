
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc83 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc83";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 82.96104d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium83() } },

        };
    }
}
    
    