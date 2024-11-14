using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon26 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon26";
        public override double halfLife { get; } = 2.2453d;
        public override double atomicWeight { get; } = 25.99233d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5069140.0), new Aluminum26() } },

        };
    }
}
    
    