using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium42m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium42m";
        public override double halfLife { get; } = 61.7d;
        public override double atomicWeight { get; } = 41.96618d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7043100.0), new Calcium42() } },

        };
    }
}
    
    