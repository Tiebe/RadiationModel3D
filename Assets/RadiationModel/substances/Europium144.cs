
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium144";
        public override double halfLife { get; } = 10.2d;
        public override double atomicWeight { get; } = 143.91882d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium144() } },

        };
    }
}
    
    