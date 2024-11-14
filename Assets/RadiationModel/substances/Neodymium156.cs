using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium156";
        public override double halfLife { get; } = 5.06d;
        public override double atomicWeight { get; } = 155.93537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3964700.0), new Promethium156() } },

        };
    }
}
    
    