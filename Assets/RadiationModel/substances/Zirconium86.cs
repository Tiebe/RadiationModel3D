using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium86";
        public override double halfLife { get; } = 59400.0d;
        public override double atomicWeight { get; } = 85.9163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1314000.0), new Yttrium86() } },

        };
    }
}
    
    