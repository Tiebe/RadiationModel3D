
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon42 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon42";
        public override double halfLife { get; } = 1038223720.8d;
        public override double atomicWeight { get; } = 41.96305d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Potassium42() } },

        };
    }
}
    
    