using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium142";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 141.96001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12870000.0), new Dysprosium142() } },
            { 0.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Dysprosium141() } },

        };
    }
}
    
    