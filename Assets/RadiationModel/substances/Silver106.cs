
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver106 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver106";
        public override double halfLife { get; } = 1437.6d;
        public override double atomicWeight { get; } = 105.90666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium106() } },

        };
    }
}
    
    