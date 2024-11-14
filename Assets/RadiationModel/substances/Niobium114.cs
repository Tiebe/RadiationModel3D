using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium114";
        public override double halfLife { get; } = 0.017d;
        public override double atomicWeight { get; } = 113.96247d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14720000.0), new Molybdenum114() } },

        };
    }
}
    
    