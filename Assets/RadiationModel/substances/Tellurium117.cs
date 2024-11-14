using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium117";
        public override double halfLife { get; } = 3720.0d;
        public override double atomicWeight { get; } = 116.90865d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3544000.0), new Antimony117() } },
            { 0.75d, new List<RadioactiveSubstance> { new Antimony117() } },
            { 0.25d, new List<RadioactiveSubstance> { new BetaParticle(1, 3544000.0), new Antimony117() } },

        };
    }
}
    
    