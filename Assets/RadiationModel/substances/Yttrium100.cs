using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium100";
        public override double halfLife { get; } = 0.94d;
        public override double atomicWeight { get; } = 99.92773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9052000.0), new Zirconium100() } },

        };
    }
}
    
    