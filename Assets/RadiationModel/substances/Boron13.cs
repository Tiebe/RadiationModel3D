using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron13 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron13";
        public override double halfLife { get; } = 0.01716d;
        public override double atomicWeight { get; } = 13.01778d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13436890.7), new Carbon13() } },

        };
    }
}
    
    