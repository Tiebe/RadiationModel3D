using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin103 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin103";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 102.92798d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium103() }, { 1.0d, new BetaParticle(1, 6780800.0) }, { 0.18d, new GammaParticle(314000.0, 0.00395) }, { 0.036000000000000004d, new GammaParticle(351300.0, 0.00353) }, { 0.044000000000000004d, new GammaParticle(355400.0, 0.00349) }, { 0.0048d, new GammaParticle(627400.0, 0.00198) }, { 0.016d, new GammaParticle(635400.0, 0.00195) }, { 0.06d, new GammaParticle(643100.0, 0.00193) }, { 0.032d, new GammaParticle(752100.0, 0.00165) }, { 0.012d, new GammaParticle(780000.0, 0.00159) }, { 0.048d, new GammaParticle(821000.0, 0.00151) }, { 0.0116d, new GammaParticle(830600.0, 0.00149) }, { 0.013600000000000001d, new GammaParticle(853000.0, 0.00145) }, { 0.012d, new GammaParticle(964300.0, 0.00129) }, { 0.027999999999999997d, new GammaParticle(993700.0, 0.00125) }, { 0.02d, new GammaParticle(1071300.0, 0.00116) }, { 0.08800000000000001d, new GammaParticle(1077600.0, 0.00115) }, { 0.02d, new GammaParticle(1134500.0, 0.00109) }, { 0.0076d, new GammaParticle(1272800.0, 0.00097) }, { 0.4d, new GammaParticle(1355800.0, 0.00091) }, { 0.172d, new GammaParticle(1396800.0, 0.00089) }, { 0.06d, new GammaParticle(1428900.0, 0.00087) }, { 0.016d, new GammaParticle(1548800.0, 0.0008) }, { 0.016d, new GammaParticle(1579800.0, 0.00078) }, { 0.052000000000000005d, new GammaParticle(1610900.0, 0.00077) }, { 0.02d, new GammaParticle(1669300.0, 0.00074) }, { 0.02d, new GammaParticle(1840900.0, 0.00067) }, { 0.016d, new GammaParticle(1908500.0, 0.00065) }, { 0.044000000000000004d, new GammaParticle(1958800.0, 0.00063) }, { 0.027999999999999997d, new GammaParticle(2049700.0, 0.0006) }, { 0.027999999999999997d, new GammaParticle(2106300.0, 0.00059) }, { 0.016d, new GammaParticle(2209300.0, 0.00056) }, { 0.04d, new GammaParticle(2813200.0, 0.00044) }, { 0.32d, new GammaParticle(511000.0, 0.00243) }, { 0.00111d, new GammaParticle(3571.0, 0.3472) }, { 0.0037d, new GammaParticle(24001.0, 0.05166) }, { 0.0069d, new GammaParticle(24209.0, 0.05121) }, { 0.0019d, new GammaParticle(27367.0, 0.0453) }, { 0.0023d, new GammaParticle(27581.0, 0.04495) }, { 0.00037d, new GammaParticle(27858.0, 0.04451) } } },
            { 0.012d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium102() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    