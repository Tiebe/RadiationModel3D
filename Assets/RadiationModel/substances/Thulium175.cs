using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium175";
        public override double halfLife { get; } = 912.0d;
        public override double atomicWeight { get; } = 174.94384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2385560.0), new Ytterbium175() } },

        };
    }
}
    
    