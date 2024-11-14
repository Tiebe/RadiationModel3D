using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium162 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium162";
        public override double halfLife { get; } = 900.0d;
        public override double atomicWeight { get; } = 161.9291d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2140200.0), new Dysprosium162() } },

        };
    }
}
    
    