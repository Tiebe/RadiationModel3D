using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium213";
        public override double halfLife { get; } = 34.17d;
        public override double atomicWeight { get; } = 212.99618d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9944d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine209() }, { 1.0d, new AlphaParticle(7927002.09) } } },
            { 0.005600000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine213() }, { 1.0d, new BetaParticle(1, 1513000.0) } } },

        };
    }
}
    