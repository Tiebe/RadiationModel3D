using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon207 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon207";
        public override double halfLife { get; } = 555.0d;
        public override double atomicWeight { get; } = 206.99073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.79d, new List<RadioactiveSubstance> { new BetaParticle(1, 4592000.0), new Astatine207() } },
            { 0.21d, new List<RadioactiveSubstance> { new AlphaParticle(7273002.09), new Polonium203() } },

        };
    }
}
    
    