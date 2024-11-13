
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine42 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine42";
        public override double halfLife { get; } = 6.8d;
        public override double atomicWeight { get; } = 41.97334d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Argon42() } },

        };
    }
}
    
    