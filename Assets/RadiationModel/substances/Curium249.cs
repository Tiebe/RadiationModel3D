using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium249 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium249";
        public override double halfLife { get; } = 3849.0d;
        public override double atomicWeight { get; } = 249.07595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 904400.0), new Berkelium249() } },

        };
    }
}
    
    