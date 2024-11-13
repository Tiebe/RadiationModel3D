
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium125";
        public override double halfLife { get; } = 0.0265d;
        public override double atomicWeight { get; } = 124.95509d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium125() } },

        };
    }
}
    
    