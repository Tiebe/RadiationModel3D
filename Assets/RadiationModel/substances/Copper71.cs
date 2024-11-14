using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper71 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper71";
        public override double halfLife { get; } = 19.4d;
        public override double atomicWeight { get; } = 70.93268d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4617700.0), new Zinc71() } },

        };
    }
}
    
    