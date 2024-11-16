using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium95";
        public override double halfLife { get; } = 618.0d;
        public override double atomicWeight { get; } = 94.91282d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4451900.0), new Zirconium95() } },

        };
    }
}
    
    