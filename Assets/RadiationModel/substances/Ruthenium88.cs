using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium88";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 87.94166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7330000.0), new Technetium88() } },

        };
    }
}
    
    