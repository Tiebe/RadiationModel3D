
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese59 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese59";
        public override double halfLife { get; } = 4.59d;
        public override double atomicWeight { get; } = 58.94039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron59() } },

        };
    }
}
    
    