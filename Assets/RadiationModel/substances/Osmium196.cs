using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium196";
        public override double halfLife { get; } = 2094.0d;
        public override double atomicWeight { get; } = 195.96964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1160000.0), new Iridium196() } },

        };
    }
}
    
    