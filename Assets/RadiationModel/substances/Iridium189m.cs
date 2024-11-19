using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189m";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 188.95912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((372000.0, 0.00333)), new Iridium189() } },

        };
    }
}
    
    