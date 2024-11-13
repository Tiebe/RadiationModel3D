
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron48 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron48";
        public override double halfLife { get; } = 0.0453d;
        public override double atomicWeight { get; } = 47.98067d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese48() } },

        };
    }
}
    
    