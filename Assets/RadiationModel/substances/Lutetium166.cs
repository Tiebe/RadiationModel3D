using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium166";
        public override double halfLife { get; } = 159.0d;
        public override double atomicWeight { get; } = 165.93986d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5573000.0), new Ytterbium166() } },

        };
    }
}
    
    