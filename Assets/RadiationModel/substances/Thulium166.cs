using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium166";
        public override double halfLife { get; } = 27720.0d;
        public override double atomicWeight { get; } = 165.93356d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3038100.0), new Erbium166() } },

        };
    }
}
    
    