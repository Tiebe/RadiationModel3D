using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80";
        public override double halfLife { get; } = 30.1d;
        public override double atomicWeight { get; } = 79.93435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9163000.0), new Strontium80() } },

        };
    }
}
    
    