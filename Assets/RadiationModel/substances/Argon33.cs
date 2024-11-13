
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon33 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon33";
        public override double halfLife { get; } = 0.173d;
        public override double atomicWeight { get; } = 32.98993d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chlorine33() } },

        };
    }
}
    
    