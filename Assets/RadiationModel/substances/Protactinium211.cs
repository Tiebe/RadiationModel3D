using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium211";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 211.02367d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9495047.4), new Actinium207() } },

        };
    }
}
    
    