using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium85";
        public override double halfLife { get; } = 471.6d;
        public override double atomicWeight { get; } = 84.92144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4667000.0), new Yttrium85() } },

        };
    }
}
    
    