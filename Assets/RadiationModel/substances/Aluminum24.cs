
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum24 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum24";
        public override double halfLife { get; } = 2.053d;
        public override double atomicWeight { get; } = 23.99995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium24() } },

        };
    }
}
    
    