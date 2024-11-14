using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium194";
        public override double halfLife { get; } = 1980.0d;
        public override double atomicWeight { get; } = 193.97108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5247000.0), new Mercury194() } },

        };
    }
}
    
    