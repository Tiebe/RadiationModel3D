using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt77 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt77";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 76.97648d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 15440000.0), new Nickel77() } },

        };
    }
}
    
    