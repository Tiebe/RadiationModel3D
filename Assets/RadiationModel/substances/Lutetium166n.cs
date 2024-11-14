using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium166n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium166n";
        public override double halfLife { get; } = 127.2d;
        public override double atomicWeight { get; } = 165.9399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(1, 5614000.0), new Ytterbium166() } },

        };
    }
}
    
    