using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium82";
        public override double halfLife { get; } = 0.05d;
        public override double atomicWeight { get; } = 81.94438d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium82() }, { 1.0d, new BetaParticle(1, 8127000.0) }, { 1.996d, new GammaParticle(511000.0, 0.00243) }, { 6.547634999999999e-05d, new GammaParticle(2161.0, 0.57374) }, { 0.00036987903933584484d, new GammaParticle(15691.0, 0.07902) }, { 0.0007079024676284111d, new GammaParticle(15775.0, 0.0786) }, { 0.00018038262917604214d, new GammaParticle(17736.0, 0.06991) }, { 0.00020671849303574428d, new GammaParticle(17824.0, 0.06956) }, { 2.6335863859702153e-05d, new GammaParticle(17968.0, 0.069) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    