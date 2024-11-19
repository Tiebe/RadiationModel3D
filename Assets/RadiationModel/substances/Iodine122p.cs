using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine122p : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122p";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 121.90801d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((394000.0, 0.00315)), new Iodine122() } },

        };
    }
}
    
    