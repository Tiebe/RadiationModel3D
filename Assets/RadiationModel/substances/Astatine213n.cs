using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine213n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine213n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 212.99615d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00041), new Astatine213() } },

        };
    }
}
    
    