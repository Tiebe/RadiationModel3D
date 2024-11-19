using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 108.90607d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((113400.00001, 0.01093)), new Palladium109() } },

        };
    }
}
    
    