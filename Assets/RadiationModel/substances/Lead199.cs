using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead199 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead199";
        public override double halfLife { get; } = 5400.0d;
        public override double atomicWeight { get; } = 198.97291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2827000.0), new Thallium199() } },

        };
    }
}
    
    