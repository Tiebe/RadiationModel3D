using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon36 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon36";
        public override double halfLife { get; } = 0.503d;
        public override double atomicWeight { get; } = 35.98665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7811000.0), new Phosphorus36() } },

        };
    }
}
    
    