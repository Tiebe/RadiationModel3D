using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium59 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium59";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 58.98243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 17390000.0), new Gallium59() } },
            { 0.002d, new List<RadioactiveSubstance> { new ProtonParticle(), new Zinc57() } },

        };
    }
}
    
    