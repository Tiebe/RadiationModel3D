using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium172";
        public override double halfLife { get; } = 228960.0d;
        public override double atomicWeight { get; } = 171.93841d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1881456.0), new Ytterbium172() } },

        };
    }
}
    
    