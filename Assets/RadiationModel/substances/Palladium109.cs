
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109";
        public override double halfLife { get; } = 48924.0d;
        public override double atomicWeight { get; } = 108.90595d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver109() } },

        };
    }
}
    
    