using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum22 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum22";
        public override double halfLife { get; } = 0.0911d;
        public override double atomicWeight { get; } = 22.01954d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 18599990.0), new Magnesium22() } },

        };
    }
}
    
    