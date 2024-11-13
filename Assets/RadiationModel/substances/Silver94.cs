
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver94 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver94";
        public override double halfLife { get; } = 0.027d;
        public override double atomicWeight { get; } = 93.94375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium94() } },

        };
    }
}
    
    