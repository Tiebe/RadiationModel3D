using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium144";
        public override double halfLife { get; } = 268.2d;
        public override double atomicWeight { get; } = 143.92296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3859000.0), new Europium144() } },

        };
    }
}
    
    