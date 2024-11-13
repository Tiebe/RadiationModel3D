
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium25 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium25";
        public override double halfLife { get; } = 59.1d;
        public override double atomicWeight { get; } = 24.98995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium25() } },

        };
    }
}
    
    