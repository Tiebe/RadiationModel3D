using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine196n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 195.99597d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((160000.0, 0.00775)), new Astatine196() } },

        };
    }
}
    
    