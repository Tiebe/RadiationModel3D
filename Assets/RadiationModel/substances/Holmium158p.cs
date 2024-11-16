using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium158p : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158p";
        public override double halfLife { get; } = 1278.0d;
        public override double atomicWeight { get; } = 157.92914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4397200.0), new Dysprosium158() } },

        };
    }
}
    
    