using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver110 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110";
        public override double halfLife { get; } = 24.56d;
        public override double atomicWeight { get; } = 109.90611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2890700.0), new Cadmium110() } },
            { 0.003d, new List<RadioactiveSubstance> { new Palladium110() } },

        };
    }
}
    
    