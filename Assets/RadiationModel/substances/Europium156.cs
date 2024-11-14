using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium156";
        public override double halfLife { get; } = 1312416.0d;
        public override double atomicWeight { get; } = 155.92476d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2452300.0), new Gadolinium156() } },

        };
    }
}
    
    