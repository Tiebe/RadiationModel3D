using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium140";
        public override double halfLife { get; } = 203.4d;
        public override double atomicWeight { get; } = 139.90909d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3388200.0), new Cerium140() } },
            { 0.48700000000000004d, new List<RadioactiveSubstance> { new BetaParticle(1, 3388200.0), new Cerium140() } },
            { 0.513d, new List<RadioactiveSubstance> { new Cerium140() } },

        };
    }
}
    
    