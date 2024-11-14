using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium162";
        public override double halfLife { get; } = 1302.0d;
        public override double atomicWeight { get; } = 161.934d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4857200.0), new Erbium162() } },

        };
    }
}
    
    