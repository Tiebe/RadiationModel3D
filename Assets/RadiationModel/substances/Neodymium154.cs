using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium154";
        public override double halfLife { get; } = 25.9d;
        public override double atomicWeight { get; } = 153.9296d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2687400.0), new Promethium154() } },

        };
    }
}
    
    