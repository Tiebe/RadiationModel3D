using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron14 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron14";
        public override double halfLife { get; } = 0.01236d;
        public override double atomicWeight { get; } = 14.0254d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 20644107.0), new Carbon14() } },

        };
    }
}
    
    