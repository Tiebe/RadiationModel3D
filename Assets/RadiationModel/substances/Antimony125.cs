
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony125 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony125";
        public override double halfLife { get; } = 87021450.8352d;
        public override double atomicWeight { get; } = 124.90525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium125() } },

        };
    }
}
    
    