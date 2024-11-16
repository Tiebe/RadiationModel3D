using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium10 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium10";
        public override double halfLife { get; } = 43769492424000.0d;
        public override double atomicWeight { get; } = 10.01353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 556879.0), new Boron10() } },

        };
    }
}
    
    