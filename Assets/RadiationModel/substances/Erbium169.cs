using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium169";
        public override double halfLife { get; } = 811468.8d;
        public override double atomicWeight { get; } = 168.9346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 353500.0), new Thulium169() } },

        };
    }
}
    
    