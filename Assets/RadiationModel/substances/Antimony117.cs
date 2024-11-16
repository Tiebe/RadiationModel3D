using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony117 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony117";
        public override double halfLife { get; } = 10692.0d;
        public override double atomicWeight { get; } = 116.90484d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1757700.0), new Tin117() } },

        };
    }
}
    
    