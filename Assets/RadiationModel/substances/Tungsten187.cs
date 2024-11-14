using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten187 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten187";
        public override double halfLife { get; } = 85712.4d;
        public override double atomicWeight { get; } = 186.95716d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1312500.0), new Rhenium187() } },

        };
    }
}
    
    