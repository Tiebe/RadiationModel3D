using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium224";
        public override double halfLife { get; } = 199.8d;
        public override double atomicWeight { get; } = 224.02335d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2923200.0), new Radium224() } },

        };
    }
}
    
    