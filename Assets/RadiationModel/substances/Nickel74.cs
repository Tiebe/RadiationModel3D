using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel74 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel74";
        public override double halfLife { get; } = 0.5077d;
        public override double atomicWeight { get; } = 73.94772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7306000.0), new Copper74() } },

        };
    }
}
    
    