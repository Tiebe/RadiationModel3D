using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine117 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine117";
        public override double halfLife { get; } = 133.2d;
        public override double atomicWeight { get; } = 116.91365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4657000.0), new Tellurium117() } },
            { 0.77d, new List<RadioactiveSubstance> { new BetaParticle(1, 4657000.0), new Tellurium117() } },

        };
    }
}
    
    