
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium123";
        public override double halfLife { get; } = 0.108d;
        public override double atomicWeight { get; } = 122.93513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver123() } },

        };
    }
}
    
    