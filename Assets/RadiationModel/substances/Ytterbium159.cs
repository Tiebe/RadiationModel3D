using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium159";
        public override double halfLife { get; } = 100.2d;
        public override double atomicWeight { get; } = 158.94006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4736000.0), new Thulium159() } },

        };
    }
}
    
    