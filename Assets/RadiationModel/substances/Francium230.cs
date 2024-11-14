using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium230";
        public override double halfLife { get; } = 19.1d;
        public override double atomicWeight { get; } = 230.04239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4971000.0), new Radium230() } },

        };
    }
}
    
    