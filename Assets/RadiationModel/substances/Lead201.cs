using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead201 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead201";
        public override double halfLife { get; } = 33588.0d;
        public override double atomicWeight { get; } = 200.97287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1910000.0), new Thallium201() } },

        };
    }
}
    
    