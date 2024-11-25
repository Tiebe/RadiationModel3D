using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium51";
        public override double halfLife { get; } = 12.4d;
        public override double atomicWeight { get; } = 50.95357d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium51() }, { 1.0d, new BetaParticle(-1, 3241300.0) }, { 0.028548d, new GammaParticle(331200.0, 0.00374) }, { 0.018304d, new GammaParticle(386700.0, 0.00321) }, { 0.033488000000000004d, new GammaParticle(576300.0, 0.00215) }, { 0.009464d, new GammaParticle(706600.0, 0.00175) }, { 0.07124d, new GammaParticle(717700.0, 0.00173) }, { 0.006084000000000001d, new GammaParticle(775600.0, 0.0016) }, { 0.008372000000000001d, new GammaParticle(887000.0, 0.0014) }, { 0.09308d, new GammaParticle(907200.0, 0.00137) }, { 0.006292d, new GammaParticle(977200.0, 0.00127) }, { 0.0026d, new GammaParticle(1033000.0, 0.0012) }, { 0.01456d, new GammaParticle(1124000.0, 0.0011) }, { 0.003328d, new GammaParticle(1163000.0, 0.00107) }, { 0.006396d, new GammaParticle(1166000.0, 0.00106) }, { 0.003952d, new GammaParticle(1253800.0, 0.00099) }, { 0.06136d, new GammaParticle(1293800.0, 0.00096) }, { 0.007124d, new GammaParticle(1351800.0, 0.00092) }, { 0.52d, new GammaParticle(1437300.0, 0.00086) }, { 0.019396d, new GammaParticle(1474400.0, 0.00084) }, { 0.0208d, new GammaParticle(1481900.0, 0.00084) }, { 0.14923999999999998d, new GammaParticle(1567500.0, 0.00079) }, { 0.0338d, new GammaParticle(1625000.0, 0.00076) }, { 0.0014039999999999999d, new GammaParticle(1750000.0, 0.00071) }, { 0.002964d, new GammaParticle(1800000.0, 0.00069) }, { 0.08268d, new GammaParticle(2051100.0, 0.0006) }, { 0.31824d, new GammaParticle(2144100.0, 0.00058) }, { 0.019396d, new GammaParticle(2181500.0, 0.00057) }, { 0.003276d, new GammaParticle(2619000.0, 0.00047) }, { 0.002288d, new GammaParticle(2691000.0, 0.00046) }, { 0.001716d, new GammaParticle(2738000.0, 0.00045) }, { 0.004368d, new GammaParticle(2919000.0, 0.00042) }, { 6.935236026576001e-08d, new GammaParticle(477.0, 2.59925) }, { 8.76819301388989e-07d, new GammaParticle(4505.0, 0.27521) }, { 1.7273823904432407e-06d, new GammaParticle(4511.0, 0.27485) }, { 3.450567241677704e-07d, new GammaParticle(4947.0, 0.25063) }, { 3.450567241677704e-07d, new GammaParticle(4947.0, 0.25063) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    