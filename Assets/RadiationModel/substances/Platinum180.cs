using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum180 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum180";
        public override double halfLife { get; } = 56.0d;
        public override double atomicWeight { get; } = 179.96304d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.997d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium180() }, { 1.0d, new BetaParticle(1, 4963000.0) } } },
            { 0.003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium176() }, { 1.0d, new AlphaParticle(6298002.09) } } },

        };
    }
}
    