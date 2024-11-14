using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium102m";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 101.93444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10511000.0), new Zirconium102() } },

        };
    }
}
    
    