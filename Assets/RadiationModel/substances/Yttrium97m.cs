using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium97m";
        public override double halfLife { get; } = 1.17d;
        public override double atomicWeight { get; } = 96.919d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.993d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7489690.0), new Zirconium97() } },
            { 0.006999999999999999d, new List<RadioactiveSubstance> { new GammaParticle((668000.0, 0.00186)), new Yttrium97() } },

        };
    }
}
    
    