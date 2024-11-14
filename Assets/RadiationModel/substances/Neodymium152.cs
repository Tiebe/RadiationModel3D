using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium152";
        public override double halfLife { get; } = 684.0d;
        public override double atomicWeight { get; } = 151.92469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1104000.0), new Promethium152() } },

        };
    }
}
    
    