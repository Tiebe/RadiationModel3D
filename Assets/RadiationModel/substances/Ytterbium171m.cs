using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium171m";
        public override double halfLife { get; } = 0.00525d;
        public override double atomicWeight { get; } = 170.93643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((95281.99998, 0.01301)), new Ytterbium171() } },

        };
    }
}
    
    