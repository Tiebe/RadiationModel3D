using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony122 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony122";
        public override double halfLife { get; } = 235336.32d;
        public override double atomicWeight { get; } = 121.90517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9759d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1979100.0), new Tellurium122() } },
            { 0.0241d, new List<RadioactiveSubstance> { new BetaParticle(1, 1605800.0), new Tin122() } },

        };
    }
}
    
    