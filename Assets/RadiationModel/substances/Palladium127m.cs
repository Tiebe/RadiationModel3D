using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium127m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 126.95115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00072), new Palladium127() } },

        };
    }
}
    
    