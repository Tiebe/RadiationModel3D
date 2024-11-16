using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197m";
        public override double halfLife { get; } = 534.0d;
        public override double atomicWeight { get; } = 196.96978d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2270800.0), new Platinum197() } },

        };
    }
}
    
    