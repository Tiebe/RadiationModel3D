using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium126p : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium126p";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 125.94699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.28d, new List<RadioactiveSubstance> { new GammaParticle((2410000.0, 0.00051)), new Palladium126() } },

        };
    }
}
    
    