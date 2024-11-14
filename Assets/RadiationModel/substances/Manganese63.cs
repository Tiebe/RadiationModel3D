using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese63 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese63";
        public override double halfLife { get; } = 0.275d;
        public override double atomicWeight { get; } = 62.94966d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8749000.0), new Iron63() } },

        };
    }
}
    
    