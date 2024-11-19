using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium212";
        public override double halfLife { get; } = 0.895d;
        public override double atomicWeight { get; } = 212.00784d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8562002.09), new Francium208() } },

        };
    }
}
    
    