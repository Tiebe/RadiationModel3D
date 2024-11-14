using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium103";
        public override double halfLife { get; } = 1.38d;
        public override double atomicWeight { get; } = 102.9272d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7220000.0), new Niobium103() } },

        };
    }
}
    
    