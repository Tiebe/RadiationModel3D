using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium84 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium84";
        public override double halfLife { get; } = 9.8d;
        public override double atomicWeight { get; } = 83.93431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10228200.0), new Zirconium84() } },

        };
    }
}
    
    