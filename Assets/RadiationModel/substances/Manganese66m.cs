using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese66m : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese66m";
        public override double halfLife { get; } = 0.00078d;
        public override double atomicWeight { get; } = 65.96105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((464000.0, 0.00267)), new Manganese66() } },

        };
    }
}
    
    