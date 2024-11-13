
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium129";
        public override double halfLife { get; } = 0.031d;
        public override double atomicWeight { get; } = 128.95933d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver129() } },

        };
    }
}
    
    