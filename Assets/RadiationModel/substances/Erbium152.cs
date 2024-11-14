using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium152";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 151.93505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(5954047.4), new Dysprosium148() } },
            { 0.1d, new List<RadioactiveSubstance> { new BetaParticle(1, 3105000.0), new Holmium152() } },

        };
    }
}
    
    