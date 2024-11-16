using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium213";
        public override double halfLife { get; } = 34.14d;
        public override double atomicWeight { get; } = 212.99618d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9944d, new List<RadioactiveSubstance> { new AlphaParticle(7925047.4), new Astatine209() } },
            { 0.005600000000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 2142000.0), new Radon213() } },

        };
    }
}
    
    