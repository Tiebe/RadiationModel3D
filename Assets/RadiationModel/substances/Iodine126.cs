using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine126 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine126";
        public override double halfLife { get; } = 1117152.0d;
        public override double atomicWeight { get; } = 125.90562d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.527d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony126() }, { 1.0d, new BetaParticle(1, -760000.0) }, { 0.32899999999999996d, new GammaParticle(666331.0, 0.00186) }, { 2e-06d, new GammaParticle(695000.0, 0.00178) }, { 0.0415d, new GammaParticle(753819.0, 0.00164) }, { 4.6e-06d, new GammaParticle(1206800.0, 0.00103) }, { 2.37e-05d, new GammaParticle(1378760.0, 0.0009) }, { 0.0030399999999999997d, new GammaParticle(1420190.0, 0.00087) }, { 4.6e-05d, new GammaParticle(2045090.0, 0.00061) }, { 0.01992d, new GammaParticle(511000.0, 0.00243) }, { 0.04019999999999999d, new GammaParticle(4135.0, 0.29984) }, { 0.1105d, new GammaParticle(27202.0, 0.04558) }, { 0.20600000000000002d, new GammaParticle(27473.0, 0.04513) }, { 0.058899999999999994d, new GammaParticle(31093.0, 0.03988) }, { 0.0717d, new GammaParticle(31359.0, 0.03954) }, { 0.0128d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.473d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon126() }, { 1.0d, new BetaParticle(-1, 618193.5) }, { 0.35600000000000004d, new GammaParticle(388633.0, 0.00319) }, { 0.0288d, new GammaParticle(491243.0, 0.00252) }, { 0.00743d, new GammaParticle(879876.0, 0.00141) }, { 0.00059385276368d, new GammaParticle(4540.0, 0.27309) }, { 0.0014624691004647325d, new GammaParticle(29458.0, 0.04209) }, { 0.002709279548841668d, new GammaParticle(29778.0, 0.04164) }, { 0.0007854093128588993d, new GammaParticle(33726.0, 0.03676) }, { 0.0009707659106935995d, new GammaParticle(34030.0, 0.03643) }, { 0.00018535659783470025d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    