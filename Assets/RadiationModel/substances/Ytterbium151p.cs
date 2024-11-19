using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium151p : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium151p";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 150.95894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3290000.0, 0.00038)), new Ytterbium151() } },

        };
    }
}
    
    