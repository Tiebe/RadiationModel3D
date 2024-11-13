
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium95";
        public override double halfLife { get; } = 0.3777d;
        public override double atomicWeight { get; } = 94.92926d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium95() } },

        };
    }
}
    
    