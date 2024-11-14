using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium172";
        public override double halfLife { get; } = 3.4d;
        public override double atomicWeight { get; } = 171.94873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3720000.0), new Holmium172() } },

        };
    }
}
    
    