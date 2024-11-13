
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium233";
        public override double halfLife { get; } = 143.0d;
        public override double atomicWeight { get; } = 233.04435d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium233() } },

        };
    }
}
    
    