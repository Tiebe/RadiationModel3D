using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium184m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium184m";
        public override double halfLife { get; } = 48.0d;
        public override double atomicWeight { get; } = 183.95681d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1270000.0, 0.00098)), new Hafnium184() } },

        };
    }
}
    
    