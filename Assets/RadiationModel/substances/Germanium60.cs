using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium60 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium60";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 59.97045d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12060000.0), new Gallium60() } },

        };
    }
}
    
    