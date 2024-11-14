using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony132m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony132m";
        public override double halfLife { get; } = 246.0d;
        public override double atomicWeight { get; } = 131.91466d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5698000.0), new Tellurium132() } },

        };
    }
}
    
    