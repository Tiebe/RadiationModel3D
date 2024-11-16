using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium240";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 240.06895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(9285047.4), new Berkelium236() } },
            { 0.3d, new List<RadioactiveSubstance> { new BetaParticle(1, 6241000.0), new Californium240() } },

        };
    }
}
    
    