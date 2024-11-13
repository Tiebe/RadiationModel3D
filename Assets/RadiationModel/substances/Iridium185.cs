
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium185 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium185";
        public override double halfLife { get; } = 51840.0d;
        public override double atomicWeight { get; } = 184.9567d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Osmium185() } },

        };
    }
}
    
    