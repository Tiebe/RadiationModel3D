using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium91";
        public override double halfLife { get; } = 21458709662.72256d;
        public override double atomicWeight { get; } = 90.90699d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium91() }, { 1.0d, new BetaParticle(1, -143350.0) }, { 0.0034000000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.03260678484d, new GammaParticle(2161.0, 0.57374) }, { 0.18379817863225753d, new GammaParticle(15691.0, 0.07902) }, { 0.35176684905695216d, new GammaParticle(15775.0, 0.0786) }, { 0.08963470533227785d, new GammaParticle(17736.0, 0.06991) }, { 0.10272137231079041d, new GammaParticle(17824.0, 0.06956) }, { 0.013086666978512566d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    