using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium111";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 110.96084d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12480000.0), new Niobium111() } },

        };
    }
}
    
    