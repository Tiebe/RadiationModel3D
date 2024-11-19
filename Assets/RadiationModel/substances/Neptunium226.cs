using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium226";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 226.03523d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9357002.09), new Protactinium222() } },

        };
    }
}
    
    