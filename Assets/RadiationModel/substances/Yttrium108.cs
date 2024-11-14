using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium108";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 107.96052d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14170000.0), new Zirconium108() } },

        };
    }
}
    
    