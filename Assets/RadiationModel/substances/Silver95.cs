using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95";
        public override double halfLife { get; } = 1.78d;
        public override double atomicWeight { get; } = 94.93568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10056000.0), new Palladium95() } },

        };
    }
}
    
    