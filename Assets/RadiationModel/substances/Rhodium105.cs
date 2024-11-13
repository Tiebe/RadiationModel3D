
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium105";
        public override double halfLife { get; } = 127227.6d;
        public override double atomicWeight { get; } = 104.90569d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium105() } },

        };
    }
}
    
    