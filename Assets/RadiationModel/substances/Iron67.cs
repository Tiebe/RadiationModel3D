
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron67 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron67";
        public override double halfLife { get; } = 0.394d;
        public override double atomicWeight { get; } = 66.95093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt67() } },

        };
    }
}
    
    