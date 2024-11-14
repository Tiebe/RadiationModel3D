using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine73 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine73";
        public override double halfLife { get; } = 204.0d;
        public override double atomicWeight { get; } = 72.93167d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4581000.0), new Selenium73() } },

        };
    }
}
    
    