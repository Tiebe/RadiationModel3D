using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium45 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium45";
        public override double halfLife { get; } = 11088.0d;
        public override double atomicWeight { get; } = 44.95812d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2062000.0), new Scandium45() } },

        };
    }
}
    
    