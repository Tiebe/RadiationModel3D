using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium179";
        public override double halfLife { get; } = 480.0d;
        public override double atomicWeight { get; } = 178.94993d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium179() }, { 1.0d, new BetaParticle(-1, 1209500.0) }, { 0.0355d, new GammaParticle(140600.0, 0.00882) }, { 0.03195d, new GammaParticle(147500.0, 0.00841) }, { 0.0639d, new GammaParticle(324500.0, 0.00382) }, { 0.056799999999999996d, new GammaParticle(351700.0, 0.00353) }, { 0.09585d, new GammaParticle(381400.0, 0.00325) }, { 0.06035d, new GammaParticle(410800.0, 0.00302) }, { 0.0070999999999999995d, new GammaParticle(426600.0, 0.00291) }, { 0.024849999999999997d, new GammaParticle(431200.0, 0.00288) }, { 0.024849999999999997d, new GammaParticle(471300.0, 0.00263) }, { 0.06035d, new GammaParticle(500000.0, 0.00248) }, { 0.0213d, new GammaParticle(522500.0, 0.00237) }, { 0.7526d, new GammaParticle(592100.0, 0.00209) }, { 0.355d, new GammaParticle(612300.0, 0.00202) }, { 0.05325d, new GammaParticle(643200.0, 0.00193) }, { 0.09230000000000001d, new GammaParticle(653700.0, 0.0019) }, { 0.028399999999999998d, new GammaParticle(993900.0, 0.00125) }, { 0.0035499999999999998d, new GammaParticle(1024400.0, 0.00121) }, { 0.03352319117904d, new GammaParticle(8810.0, 0.14073) }, { 0.03532557909180468d, new GammaParticle(52965.0, 0.02341) }, { 0.06204000542993446d, new GammaParticle(54070.0, 0.02293) }, { 0.020412879666345623d, new GammaParticle(61387.0, 0.0202) }, { 0.025801879898260868d, new GammaParticle(62084.0, 0.01997) }, { 0.0053890002319152445d, new GammaParticle(62927.0, 0.0197) } } },

        };
    }
}
    