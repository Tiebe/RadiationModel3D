
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium89";
        public override double halfLife { get; } = 4368643.2d;
        public override double atomicWeight { get; } = 88.90745d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium89() } },

        };
    }
}
    
    