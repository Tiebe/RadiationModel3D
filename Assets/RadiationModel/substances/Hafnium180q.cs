using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium180q : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium180q";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 179.95042d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3599000.0, 0.00034)), new Hafnium180() } },

        };
    }
}
    
    