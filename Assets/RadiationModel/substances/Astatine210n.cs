using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine210n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine210n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 209.99147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4028000.0, 0.00031)), new Astatine210() } },

        };
    }
}
    
    