using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten190n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190n";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 189.96508d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00067, 1840000.0), new Tungsten190() } },

        };
    }
}
    
    