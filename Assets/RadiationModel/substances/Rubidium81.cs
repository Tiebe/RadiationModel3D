using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium81";
        public override double halfLife { get; } = 16459.2d;
        public override double atomicWeight { get; } = 80.91899d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2239200.0), new Krypton81() } },

        };
    }
}
    
    