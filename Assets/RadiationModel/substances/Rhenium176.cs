using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium176";
        public override double halfLife { get; } = 318.0d;
        public override double atomicWeight { get; } = 175.95162d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5579000.0), new Tungsten176() } },

        };
    }
}
    
    