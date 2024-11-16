using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium209";
        public override double halfLife { get; } = 50.5d;
        public override double atomicWeight { get; } = 208.99594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(7800002.09), new Astatine205() } },
            { 0.11d, new List<RadioactiveSubstance> { new BetaParticle(1, 5159000.0), new Radon209() } },

        };
    }
}
    
    