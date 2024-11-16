using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon109 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon109";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 108.95043d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5237002.09), new Tellurium105() } },

        };
    }
}
    
    