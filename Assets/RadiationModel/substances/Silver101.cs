using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver101 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver101";
        public override double halfLife { get; } = 666.0d;
        public override double atomicWeight { get; } = 100.91268d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4098000.0), new Palladium101() } },

        };
    }
}
    
    