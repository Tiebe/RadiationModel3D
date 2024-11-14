using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt56 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt56";
        public override double halfLife { get; } = 6673190.4d;
        public override double atomicWeight { get; } = 55.93984d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4566660.0), new Iron56() } },

        };
    }
}
    
    