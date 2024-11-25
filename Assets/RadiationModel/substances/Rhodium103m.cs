using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium103m";
        public override double halfLife { get; } = 3366.84d;
        public override double atomicWeight { get; } = 102.90554d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium103() }, { 0.000684d, new GammaParticle(39755.0, 0.03119) }, { 0.0389712013704d, new GammaParticle(2892.0, 0.42871) }, { 0.020120896126968067d, new GammaParticle(20073.0, 0.06177) }, { 0.0380933285251194d, new GammaParticle(20215.0, 0.06133) }, { 0.01034475758826117d, new GammaParticle(22806.0, 0.05436) }, { 0.012061987347912523d, new GammaParticle(22957.0, 0.05401) }, { 0.0017172297596513542d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    