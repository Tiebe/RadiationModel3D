
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium144";
        public override double halfLife { get; } = 11.73d;
        public override double atomicWeight { get; } = 143.92295d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum144() } },

        };
    }
}
    
    