using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium154n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium154n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 153.96033d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00046, 2720000.0), new Lutetium154() } },

        };
    }
}
    
    