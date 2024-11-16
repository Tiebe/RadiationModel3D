using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium98";
        public override double halfLife { get; } = 30.7d;
        public override double atomicWeight { get; } = 97.91274d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2243000.0), new Niobium98() } },

        };
    }
}
    
    