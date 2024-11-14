using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium131m";
        public override double halfLife { get; } = 324.0d;
        public override double atomicWeight { get; } = 130.91449d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4119000.0), new Lanthanum131() } },

        };
    }
}
    
    