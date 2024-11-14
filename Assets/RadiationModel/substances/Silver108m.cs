using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver108m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver108m";
        public override double halfLife { get; } = 13853501928.0d;
        public override double atomicWeight { get; } = 107.90607d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9129999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 2026900.0), new Palladium108() } },
            { 0.087d, new List<RadioactiveSubstance> { new GammaParticle(0.01132), new Silver108() } },

        };
    }
}
    
    