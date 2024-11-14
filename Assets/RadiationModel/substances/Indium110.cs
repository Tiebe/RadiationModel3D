using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium110";
        public override double halfLife { get; } = 17712.0d;
        public override double atomicWeight { get; } = 109.90717d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3878000.0), new Cadmium110() } },

        };
    }
}
    
    