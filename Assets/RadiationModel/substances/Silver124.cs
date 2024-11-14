using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver124 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver124";
        public override double halfLife { get; } = 0.1779d;
        public override double atomicWeight { get; } = 123.9289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10469400.0), new Cadmium124() } },

        };
    }
}
    
    