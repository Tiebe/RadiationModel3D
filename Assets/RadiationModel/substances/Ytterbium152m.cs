using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium152m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium152m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 151.95327d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2740000.0, 0.00045)), new Ytterbium152() } },

        };
    }
}
    
    