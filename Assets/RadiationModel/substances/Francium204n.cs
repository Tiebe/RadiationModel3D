using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium204n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204n";
        public override double halfLife { get; } = 1.65d;
        public override double atomicWeight { get; } = 204.001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.53d, new List<RadioactiveSubstance> { new AlphaParticle(8519002.09), new Astatine200() } },
            { 0.47d, new List<RadioactiveSubstance> { new GammaParticle((327000.0, 0.00379)), new Francium204() } },

        };
    }
}
    
    