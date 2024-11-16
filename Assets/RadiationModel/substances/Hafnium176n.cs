using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 175.94308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1559300.00001, 0.0008)), new Hafnium176() } },

        };
    }
}
    
    