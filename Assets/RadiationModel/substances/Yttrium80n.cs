using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium80n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium80n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 79.93469d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00396), new Yttrium80() } },

        };
    }
}
    
    