using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium208";
        public override double halfLife { get; } = 59.1d;
        public override double atomicWeight { get; } = 207.99714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(7805047.4), new Astatine204() } },
            { 0.11d, new List<RadioactiveSubstance> { new BetaParticle(1, 6990000.0), new Radon208() } },

        };
    }
}
    
    