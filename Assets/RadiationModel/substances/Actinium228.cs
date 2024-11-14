using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium228";
        public override double halfLife { get; } = 22140.0d;
        public override double atomicWeight { get; } = 228.03102d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2123800.0), new Thorium228() } },

        };
    }
}
    
    