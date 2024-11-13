
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper61 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper61";
        public override double halfLife { get; } = 12034.8d;
        public override double atomicWeight { get; } = 60.93346d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Nickel61() } },

        };
    }
}
    
    