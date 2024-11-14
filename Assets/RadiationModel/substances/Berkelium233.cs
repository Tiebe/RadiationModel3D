using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium233";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 233.05665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new List<RadioactiveSubstance> { new AlphaParticle(9185047.4), new Americium229() } },

        };
    }
}
    
    