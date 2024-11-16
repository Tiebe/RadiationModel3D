using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium86";
        public override double halfLife { get; } = 53064.0d;
        public override double atomicWeight { get; } = 85.91489d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5240100.0), new Strontium86() } },

        };
    }
}
    
    