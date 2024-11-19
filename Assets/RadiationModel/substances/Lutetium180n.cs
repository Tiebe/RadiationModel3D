using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium180n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium180n";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 179.95055d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((620000.0, 0.002)), new Lutetium180() } },

        };
    }
}
    
    