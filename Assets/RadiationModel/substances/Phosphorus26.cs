using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus26 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus26";
        public override double halfLife { get; } = 0.0437d;
        public override double atomicWeight { get; } = 26.01178d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum26() }, { 1.0d, new BetaParticle(1, 11590070.0) }, { 0.013000000000000001d, new GammaParticle(970500.0, 0.00128) }, { 0.052000000000000005d, new GammaParticle(988900.0, 0.00125) }, { 0.027999999999999997d, new GammaParticle(1400500.0, 0.00089) }, { 0.0018d, new GammaParticle(1741600.0, 0.00071) }, { 0.52d, new GammaParticle(1797200.0, 0.00069) }, { 0.013000000000000001d, new GammaParticle(1960100.0, 0.00063) }, { 0.013999999999999999d, new GammaParticle(2044800.0, 0.00061) }, { 0.013000000000000001d, new GammaParticle(2341800.0, 0.00053) }, { 1.8906d, new GammaParticle(511000.0, 0.00243) }, { 3.18390875e-08d, new GammaParticle(118.0, 10.50714) }, { 9.494946478957347e-07d, new GammaParticle(1740.0, 0.71255) }, { 4.782604541450816e-07d, new GammaParticle(1740.0, 0.71255) }, { 4.140489795918367e-08d, new GammaParticle(1836.0, 0.6753) }, { 4.140489795918367e-08d, new GammaParticle(1836.0, 0.6753) } } },
            { 0.368d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum25() }, { 1.0d, new ProtonParticle() } } },
            { 0.0216d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium24() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    