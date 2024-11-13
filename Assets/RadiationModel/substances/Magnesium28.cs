
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium28 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium28";
        public override double halfLife { get; } = 75294.0d;
        public override double atomicWeight { get; } = 27.98388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum28() } },

        };
    }
}
    
    