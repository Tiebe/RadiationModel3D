using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum111 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum111";
        public override double halfLife { get; } = 0.1936d;
        public override double atomicWeight { get; } = 110.93565d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9085000.0), new Technetium111() } },

        };
    }
}
    
    