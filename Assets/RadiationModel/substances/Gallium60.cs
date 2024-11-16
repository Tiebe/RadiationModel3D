using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium60";
        public override double halfLife { get; } = 0.0724d;
        public override double atomicWeight { get; } = 59.9575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14584500.0), new Zinc60() } },

        };
    }
}
    
    