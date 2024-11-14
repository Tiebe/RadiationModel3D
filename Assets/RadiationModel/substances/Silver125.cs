using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver125 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver125";
        public override double halfLife { get; } = 0.16d;
        public override double atomicWeight { get; } = 124.93073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8828100.0), new Cadmium125() } },

        };
    }
}
    
    