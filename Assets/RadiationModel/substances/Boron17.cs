using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron17 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron17";
        public override double halfLife { get; } = 0.00508d;
        public override double atomicWeight { get; } = 17.04694d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon17() }, { 1.0d, new BetaParticle(-1, 11344000.0) }, { 0.027999999999999997d, new GammaParticle(217000.0, 0.00571) }, { 0.021d, new GammaParticle(331000.0, 0.00375) } } },
            { 0.63d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon17() }, { 1.0d, new BetaParticle(-1, 11344000.0) }, { 0.027999999999999997d, new GammaParticle(217000.0, 0.00571) }, { 0.021d, new GammaParticle(331000.0, 0.00375) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Carbon15() }, { 1.0d, new BetaParticle(-1, 948417553.472) }, { 1.0d, new NeutronParticle() } } },

        };
    }
}
    