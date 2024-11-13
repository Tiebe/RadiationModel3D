
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium81";
        public override double halfLife { get; } = 1338.0d;
        public override double atomicWeight { get; } = 80.92321d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium81() } },

        };
    }
}
    
    