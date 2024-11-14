using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium218";
        public override double halfLife { get; } = 0.00011d;
        public override double atomicWeight { get; } = 218.02002d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10812047.4), new Actinium214() } },

        };
    }
}
    
    