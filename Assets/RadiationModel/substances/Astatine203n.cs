using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine203n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine203n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 202.98944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2330000.0, 0.00053)), new Astatine203() } },

        };
    }
}
    
    