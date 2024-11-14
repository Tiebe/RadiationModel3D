using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium88m";
        public override double halfLife { get; } = 462.0d;
        public override double atomicWeight { get; } = 87.91837d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7589000.0), new Zirconium88() } },

        };
    }
}
    
    