using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium197n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 196.97149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1704000.0, 0.00073)), new Iridium197() } },

        };
    }
}
    
    