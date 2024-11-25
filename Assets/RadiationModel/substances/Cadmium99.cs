using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium99";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 98.92493d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium99() }, { 1.0d, new BetaParticle(1, 6125950.0) } } },
            { 0.0017000000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium98() }, { 1.0d, new BetaParticle(1, 471442001.736) }, { 1.0d, new ProtonParticle() } } },
            { 1e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver99() }, { 1.0d, new BetaParticle(1, 3390450.0) } } },

        };
    }
}
    