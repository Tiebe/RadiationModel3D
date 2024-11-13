
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium75 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium75";
        public override double halfLife { get; } = 0.0852d;
        public override double atomicWeight { get; } = 74.94995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rubidium75() } },

        };
    }
}
    
    