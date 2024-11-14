using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen21 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen21";
        public override double halfLife { get; } = 0.085d;
        public override double atomicWeight { get; } = 21.02709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 17168000.0), new Oxygen21() } },

        };
    }
}
    
    