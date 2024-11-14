using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum33 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum33";
        public override double halfLife { get; } = 0.04146d;
        public override double atomicWeight { get; } = 32.99088d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12017300.0), new Silicon33() } },

        };
    }
}
    
    