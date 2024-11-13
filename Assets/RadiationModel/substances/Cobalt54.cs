
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt54 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt54";
        public override double halfLife { get; } = 0.19327d;
        public override double atomicWeight { get; } = 53.94846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iron54() } },

        };
    }
}
    
    