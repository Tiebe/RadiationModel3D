using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium195 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium195";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 194.97256d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3950000.0), new Osmium195() } },

        };
    }
}
    
    