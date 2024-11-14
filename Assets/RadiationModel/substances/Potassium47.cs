using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium47";
        public override double halfLife { get; } = 17.38d;
        public override double atomicWeight { get; } = 46.96166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6632700.0), new Calcium47() } },

        };
    }
}
    
    