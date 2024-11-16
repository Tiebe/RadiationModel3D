using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium247";
        public override double halfLife { get; } = 492288451200000.0d;
        public override double atomicWeight { get; } = 247.07035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6375402.09), new Plutonium243() } },

        };
    }
}
    
    