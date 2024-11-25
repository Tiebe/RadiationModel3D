using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium98";
        public override double halfLife { get; } = 1062.0d;
        public override double atomicWeight { get; } = 97.9127d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium98() }, { 1.0d, new BetaParticle(1, 3452000.0) }, { 0.085d, new GammaParticle(67700.0, 0.01831) }, { 0.13699999999999998d, new GammaParticle(106800.0, 0.01161) }, { 0.579d, new GammaParticle(112200.0, 0.01105) }, { 0.07200000000000001d, new GammaParticle(174500.0, 0.00711) }, { 0.19399999999999998d, new GammaParticle(661900.0, 0.00187) }, { 0.039d, new GammaParticle(725600.0, 0.00171) }, { 0.031d, new GammaParticle(832800.0, 0.00149) }, { 0.0026d, new GammaParticle(837600.0, 0.00148) }, { 0.015d, new GammaParticle(895400.0, 0.00138) }, { 0.0038d, new GammaParticle(999900.0, 0.00124) }, { 0.0127d, new GammaParticle(1007500.0, 0.00123) }, { 0.0139d, new GammaParticle(1087700.0, 0.00114) }, { 0.0058d, new GammaParticle(1111900.0, 0.00112) }, { 0.0069d, new GammaParticle(1150100.0, 0.00108) }, { 0.0029d, new GammaParticle(1262500.0, 0.00098) }, { 0.0926d, new GammaParticle(511000.0, 0.00243) }, { 0.059000000000000004d, new GammaParticle(2892.0, 0.42871) }, { 0.249d, new GammaParticle(20073.0, 0.06177) }, { 0.47100000000000003d, new GammaParticle(20215.0, 0.06133) }, { 0.128d, new GammaParticle(22806.0, 0.05436) }, { 0.149d, new GammaParticle(22957.0, 0.05401) }, { 0.0212d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    