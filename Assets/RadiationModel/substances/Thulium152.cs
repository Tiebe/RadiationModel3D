using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium152";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 151.94448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8780000.0), new Erbium152() } },

        };
    }
}
    
    