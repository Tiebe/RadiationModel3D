using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper58 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper58";
        public override double halfLife { get; } = 3.204d;
        public override double atomicWeight { get; } = 57.94453d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8561000.0), new Nickel58() } },

        };
    }
}
    
    