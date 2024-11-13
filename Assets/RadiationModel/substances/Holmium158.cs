
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158";
        public override double halfLife { get; } = 678.0d;
        public override double atomicWeight { get; } = 157.92895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium158() } },

        };
    }
}
    
    