using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium95m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 94.91399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1088000.0, 0.00114)), new Yttrium95() } },

        };
    }
}
    
    