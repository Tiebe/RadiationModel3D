using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium192n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium192n";
        public override double halfLife { get; } = 7605225432.0d;
        public override double atomicWeight { get; } = 191.96278d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((168099.99999, 0.00738)), new Iridium192() } },

        };
    }
}
    
    