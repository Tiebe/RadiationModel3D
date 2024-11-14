using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium136";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 135.92828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4359000.0), new Promethium136() } },

        };
    }
}
    
    