
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese62 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese62";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 61.94791d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron62() } },

        };
    }
}
    
    