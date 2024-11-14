using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium91";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 90.92674d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7746900.0), new Technetium91() } },

        };
    }
}
    
    