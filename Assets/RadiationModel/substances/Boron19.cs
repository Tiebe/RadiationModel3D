using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron19 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron19";
        public override double halfLife { get; } = 0.00292d;
        public override double atomicWeight { get; } = 19.06417d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon19() }, { 1.0d, new BetaParticle(-1, 13680000.0) } } },
            { 0.718d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon19() }, { 1.0d, new BetaParticle(-1, 13680000.0) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon17() }, { 1.0d, new BetaParticle(-1, 950863103.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    