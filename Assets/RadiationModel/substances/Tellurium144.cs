
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium144";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 143.96112d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine144() } },

        };
    }
}
    
    