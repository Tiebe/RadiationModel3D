using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium122";
        public override double halfLife { get; } = 0.193d;
        public override double atomicWeight { get; } = 121.93063d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6494000.0), new Silver122() } },

        };
    }
}
    
    