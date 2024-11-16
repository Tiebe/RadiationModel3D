using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum150 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum150";
        public override double halfLife { get; } = 0.504d;
        public override double atomicWeight { get; } = 149.93955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8535900.0), new Cerium150() } },

        };
    }
}
    
    