using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron60 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron60";
        public override double halfLife { get; } = 82679214240000.02d;
        public override double atomicWeight { get; } = 59.93407d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 237400.0), new Cobalt60() } },

        };
    }
}
    
    