using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper64 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper64";
        public override double halfLife { get; } = 45721.44d;
        public override double atomicWeight { get; } = 63.92976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6152000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 1674600.0), new Nickel64() } },
            { 0.3848d, new List<RadioactiveSubstance> { new BetaParticle(-1, 579600.0), new Zinc64() } },

        };
    }
}
    
    