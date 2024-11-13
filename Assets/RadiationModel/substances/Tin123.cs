
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin123 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin123";
        public override double halfLife { get; } = 11162880.0d;
        public override double atomicWeight { get; } = 122.90573d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Antimony123() } },

        };
    }
}
    
    