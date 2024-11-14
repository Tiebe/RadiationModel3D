using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium156";
        public override double halfLife { get; } = 1170.0d;
        public override double atomicWeight { get; } = 155.93107d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1328000.0), new Holmium156() } },
            { 1.2000000000000002e-07d, new List<RadioactiveSubstance> { new AlphaParticle(4501047.4), new Dysprosium152() } },

        };
    }
}
    
    