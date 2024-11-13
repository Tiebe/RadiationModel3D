
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium33";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 33.00533d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum33() } },

        };
    }
}
    
    