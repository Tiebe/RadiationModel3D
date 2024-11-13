
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium130";
        public override double halfLife { get; } = 2.4961549032e+28d;
        public override double atomicWeight { get; } = 129.90622d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon130() } },

        };
    }
}
    
    