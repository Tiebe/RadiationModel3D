
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum144 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum144";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 143.91965d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cerium144() } },

        };
    }
}
    
    