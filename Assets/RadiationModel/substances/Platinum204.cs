using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum204 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum204";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 203.98108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2770000.0), new Gold204() } },

        };
    }
}
    
    