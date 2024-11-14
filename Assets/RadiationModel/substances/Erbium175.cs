using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium175";
        public override double halfLife { get; } = 72.0d;
        public override double atomicWeight { get; } = 174.94777d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3660000.0), new Thulium175() } },

        };
    }
}
    
    