using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese56 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese56";
        public override double halfLife { get; } = 9284.04d;
        public override double atomicWeight { get; } = 55.9389d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3695490.0), new Iron56() } },

        };
    }
}
    
    