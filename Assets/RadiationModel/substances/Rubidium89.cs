
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium89";
        public override double halfLife { get; } = 919.2d;
        public override double atomicWeight { get; } = 88.91228d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium89() } },

        };
    }
}
    
    