
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead216 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead216";
        public override double halfLife { get; } = 99.6d;
        public override double atomicWeight { get; } = 216.00806d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth216() } },

        };
    }
}
    
    