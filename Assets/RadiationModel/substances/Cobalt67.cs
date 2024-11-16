using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt67 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt67";
        public override double halfLife { get; } = 0.329d;
        public override double atomicWeight { get; } = 66.94061d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8420700.0), new Nickel67() } },

        };
    }
}
    
    