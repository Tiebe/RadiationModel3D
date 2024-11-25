using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium52 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium52";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 51.96321d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium52() }, { 1.0d, new BetaParticle(-1, 3128850.0) }, { 0.624d, new GammaParticle(675200.0, 0.00184) }, { 0.49920000000000003d, new GammaParticle(961200.0, 0.00129) }, { 0.35568d, new GammaParticle(1636400.0, 0.00076) }, { 0.11231999999999999d, new GammaParticle(2070400.0, 0.0006) }, { 0.00624d, new GammaParticle(3458000.0, 0.00036) }, { 0.013728d, new GammaParticle(4265500.0, 0.00029) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    