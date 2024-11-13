
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth208 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth208";
        public override double halfLife { get; } = 11612958336000.0d;
        public override double atomicWeight { get; } = 207.97974d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead208() } },

        };
    }
}
    
    