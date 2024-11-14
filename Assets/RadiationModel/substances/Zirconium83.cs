using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium83";
        public override double halfLife { get; } = 42.0d;
        public override double atomicWeight { get; } = 82.92924d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6294000.0), new Yttrium83() } },

        };
    }
}
    
    