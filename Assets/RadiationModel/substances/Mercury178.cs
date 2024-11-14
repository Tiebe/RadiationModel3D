using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury178 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury178";
        public override double halfLife { get; } = 0.2665d;
        public override double atomicWeight { get; } = 177.98249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(7598047.4), new Platinum174() } },

        };
    }
}
    
    