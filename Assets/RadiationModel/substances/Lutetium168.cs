using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium168";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 167.93873d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4509870.0), new Ytterbium168() } },

        };
    }
}
    
    