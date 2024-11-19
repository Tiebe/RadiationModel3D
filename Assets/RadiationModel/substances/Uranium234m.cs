using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium234m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium234m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 234.04248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00087, 1421300.0), new Uranium234() } },

        };
    }
}
    
    