using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium33 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium33";
        public override double halfLife { get; } = 0.0905d;
        public override double atomicWeight { get; } = 33.00533d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum33() }, { 1.0d, new BetaParticle(-1, 6729950.0) }, { 0.05d, new GammaParticle(596000.0, 0.00208) }, { 0.04d, new GammaParticle(1046000.0, 0.00119) }, { 0.03d, new GammaParticle(1466000.0, 0.00085) }, { 0.16d, new GammaParticle(1618000.0, 0.00077) }, { 0.07d, new GammaParticle(1647000.0, 0.00075) }, { 0.09d, new GammaParticle(1838000.0, 0.00067) }, { 0.09d, new GammaParticle(2096000.0, 0.00059) }, { 0.07d, new GammaParticle(2365000.0, 0.00052) }, { 0.04d, new GammaParticle(2692000.0, 0.00046) }, { 0.03d, new GammaParticle(2892000.0, 0.00043) }, { 0.08d, new GammaParticle(3714000.0, 0.00033) }, { 0.1d, new GammaParticle(4730000.0, 0.00026) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum33() }, { 1.0d, new BetaParticle(-1, 6729950.0) }, { 0.05d, new GammaParticle(596000.0, 0.00208) }, { 0.04d, new GammaParticle(1046000.0, 0.00119) }, { 0.03d, new GammaParticle(1466000.0, 0.00085) }, { 0.16d, new GammaParticle(1618000.0, 0.00077) }, { 0.07d, new GammaParticle(1647000.0, 0.00075) }, { 0.09d, new GammaParticle(1838000.0, 0.00067) }, { 0.09d, new GammaParticle(2096000.0, 0.00059) }, { 0.07d, new GammaParticle(2365000.0, 0.00052) }, { 0.04d, new GammaParticle(2692000.0, 0.00046) }, { 0.03d, new GammaParticle(2892000.0, 0.00043) }, { 0.08d, new GammaParticle(3714000.0, 0.00033) }, { 0.1d, new GammaParticle(4730000.0, 0.00026) } } },

        };
    }
}
    