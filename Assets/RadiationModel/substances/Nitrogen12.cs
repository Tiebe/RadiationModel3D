
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen12 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen12";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 12.01861d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Carbon12() } },

        };
    }
}
    
    