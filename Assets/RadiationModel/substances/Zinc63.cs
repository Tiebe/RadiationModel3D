using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc63 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc63";
        public override double halfLife { get; } = 2308.2d;
        public override double atomicWeight { get; } = 62.93321d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3366500.0), new Copper63() } },

        };
    }
}
    
    