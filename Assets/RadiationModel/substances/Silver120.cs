using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver120 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver120";
        public override double halfLife { get; } = 1.52d;
        public override double atomicWeight { get; } = 119.91878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8305000.0), new Cadmium120() } },

        };
    }
}
    
    