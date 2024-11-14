using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium172";
        public override double halfLife { get; } = 177480.0d;
        public override double atomicWeight { get; } = 171.93936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 891000.0), new Thulium172() } },

        };
    }
}
    
    