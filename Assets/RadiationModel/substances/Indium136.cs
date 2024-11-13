
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium136";
        public override double halfLife { get; } = 0.086d;
        public override double atomicWeight { get; } = 135.95602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin136() } },

        };
    }
}
    
    