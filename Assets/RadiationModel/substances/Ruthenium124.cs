using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium124";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 123.96394d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11120000.0), new Rhodium124() } },

        };
    }
}
    
    