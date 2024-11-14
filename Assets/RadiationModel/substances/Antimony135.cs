using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony135 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony135";
        public override double halfLife { get; } = 1.668d;
        public override double atomicWeight { get; } = 134.92518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8038500.0), new Tellurium135() } },

        };
    }
}
    
    