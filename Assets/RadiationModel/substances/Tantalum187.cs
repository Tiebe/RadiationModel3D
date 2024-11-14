using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum187 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum187";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 186.96039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3004000.0), new Tungsten187() } },

        };
    }
}
    
    