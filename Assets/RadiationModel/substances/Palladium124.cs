using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium124";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 123.93731d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7830000.0), new Silver124() } },

        };
    }
}
    
    