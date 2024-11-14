using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur46 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur46";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 46.00069d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14370000.0), new Chlorine46() } },

        };
    }
}
    
    