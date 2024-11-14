using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper60 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper60";
        public override double halfLife { get; } = 1422.0d;
        public override double atomicWeight { get; } = 59.93736d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6127900.0), new Nickel60() } },

        };
    }
}
    
    