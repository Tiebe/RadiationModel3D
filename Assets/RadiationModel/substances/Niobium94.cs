using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium94";
        public override double halfLife { get; } = 643761820800.0d;
        public override double atomicWeight { get; } = 93.90728d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2044980.0), new Molybdenum94() } },

        };
    }
}
    
    