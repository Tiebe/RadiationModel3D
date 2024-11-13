
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron46 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron46";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 46.0013d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese46() } },

        };
    }
}
    
    