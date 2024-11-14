using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium232";
        public override double halfLife { get; } = 114048.0d;
        public override double atomicWeight { get; } = 232.03859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1337600.0), new Uranium232() } },

        };
    }
}
    
    