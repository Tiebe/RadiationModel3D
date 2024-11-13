
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium95";
        public override double halfLife { get; } = 23.9d;
        public override double atomicWeight { get; } = 94.91936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium95() } },

        };
    }
}
    
    