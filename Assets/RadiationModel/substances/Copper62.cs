using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper62 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper62";
        public override double halfLife { get; } = 580.32d;
        public override double atomicWeight { get; } = 61.93259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3958900.0), new Nickel62() } },

        };
    }
}
    
    