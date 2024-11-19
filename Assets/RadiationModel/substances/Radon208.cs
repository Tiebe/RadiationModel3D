using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon208 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon208";
        public override double halfLife { get; } = 1461.0d;
        public override double atomicWeight { get; } = 207.98963d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.62d, new List<RadioactiveSubstance> { new AlphaParticle(7283002.09), new Polonium204() } },
            { 0.38d, new List<RadioactiveSubstance> { new BetaParticle(1, 2815000.0), new Astatine208() } },

        };
    }
}
    
    