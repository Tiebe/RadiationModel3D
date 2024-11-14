using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc58 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc58";
        public override double halfLife { get; } = 0.086d;
        public override double atomicWeight { get; } = 57.95459d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9367900.0), new Copper58() } },

        };
    }
}
    
    