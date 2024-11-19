using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium152";
        public override double halfLife { get; } = 161.8d;
        public override double atomicWeight { get; } = 151.93172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new BetaParticle(1, 6513000.0), new Dysprosium152() } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(5529002.09), new Terbium148() } },

        };
    }
}
    
    