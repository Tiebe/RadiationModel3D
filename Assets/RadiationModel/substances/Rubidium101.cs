using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium101";
        public override double halfLife { get; } = 0.0318d;
        public override double atomicWeight { get; } = 100.9543d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12758000.0), new Strontium101() } },

        };
    }
}
    
    