using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead199n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead199n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 198.97566d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2564000.0, 0.00048)), new Lead199() } },

        };
    }
}
    
    