using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium153";
        public override double halfLife { get; } = 37.1d;
        public override double atomicWeight { get; } = 152.93509d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.53d, new List<RadioactiveSubstance> { new AlphaParticle(5822047.4), new Dysprosium149() } },
            { 0.47d, new List<RadioactiveSubstance> { new BetaParticle(1, 4545000.0), new Holmium153() } },

        };
    }
}
    
    