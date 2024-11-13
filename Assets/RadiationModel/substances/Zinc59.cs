
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc59 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc59";
        public override double halfLife { get; } = 0.1787d;
        public override double atomicWeight { get; } = 58.94931d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Copper59() } },

        };
    }
}
    
    