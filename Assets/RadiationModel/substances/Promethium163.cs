using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium163";
        public override double halfLife { get; } = 0.255d;
        public override double atomicWeight { get; } = 162.95388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7640000.0), new Samarium163() } },

        };
    }
}
    
    