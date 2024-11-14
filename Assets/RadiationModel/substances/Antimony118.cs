using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony118 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony118";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 117.90553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3656800.0), new Tin118() } },

        };
    }
}
    
    