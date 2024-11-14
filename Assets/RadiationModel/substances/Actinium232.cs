using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium232";
        public override double halfLife { get; } = 118.8d;
        public override double atomicWeight { get; } = 232.04203d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3707300.0), new Thorium232() } },

        };
    }
}
    
    