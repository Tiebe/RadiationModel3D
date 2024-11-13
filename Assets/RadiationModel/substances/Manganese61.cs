
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese61 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese61";
        public override double halfLife { get; } = 0.709d;
        public override double atomicWeight { get; } = 60.94445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron61() } },

        };
    }
}
    
    