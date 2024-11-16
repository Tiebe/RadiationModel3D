using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony132 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony132";
        public override double halfLife { get; } = 167.4d;
        public override double atomicWeight { get; } = 131.91451d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5552700.0), new Tellurium132() } },

        };
    }
}
    
    