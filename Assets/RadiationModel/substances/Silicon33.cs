using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon33 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon33";
        public override double halfLife { get; } = 6.18d;
        public override double atomicWeight { get; } = 32.97798d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5823100.0), new Phosphorus33() } },

        };
    }
}
    
    