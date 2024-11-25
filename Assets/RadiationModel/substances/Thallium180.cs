using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium180";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 179.98992d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold180() }, { 1.0d, new BetaParticle(1, 8118000.0) }, { 0.01d, new GammaParticle(104700.0, 0.01184) }, { 0.0241d, new GammaParticle(167000.0, 0.00742) }, { 0.00117d, new GammaParticle(181800.0, 0.00682) }, { 0.39d, new GammaParticle(272000.0, 0.00456) }, { 0.11199999999999999d, new GammaParticle(325800.0, 0.00381) }, { 0.040999999999999995d, new GammaParticle(326800.0, 0.00379) }, { 0.02d, new GammaParticle(328600.0, 0.00377) }, { 0.0212d, new GammaParticle(398200.0, 0.00311) }, { 0.73d, new GammaParticle(434000.0, 0.00286) }, { 0.008d, new GammaParticle(472500.0, 0.00262) }, { 0.0095d, new GammaParticle(498100.0, 0.00249) }, { 0.025d, new GammaParticle(517400.0, 0.0024) }, { 0.022000000000000002d, new GammaParticle(551100.0, 0.00225) }, { 0.021d, new GammaParticle(553000.0, 0.00224) }, { 0.011699999999999999d, new GammaParticle(573400.0, 0.00216) }, { 0.17800000000000002d, new GammaParticle(601600.0, 0.00206) }, { 0.011000000000000001d, new GammaParticle(602400.0, 0.00206) }, { 0.135d, new GammaParticle(622000.0, 0.00199) }, { 0.0073d, new GammaParticle(657300.0, 0.00189) }, { 0.0058d, new GammaParticle(671600.0, 0.00185) }, { 0.0176d, new GammaParticle(692900.0, 0.00179) }, { 0.011000000000000001d, new GammaParticle(765400.0, 0.00162) }, { 0.0256d, new GammaParticle(769700.0, 0.00161) }, { 0.076d, new GammaParticle(789400.0, 0.00157) }, { 0.033d, new GammaParticle(797700.0, 0.00155) }, { 0.037000000000000005d, new GammaParticle(798000.0, 0.00155) }, { 0.067d, new GammaParticle(798100.0, 0.00155) }, { 0.0139d, new GammaParticle(867100.0, 0.00143) }, { 0.037000000000000005d, new GammaParticle(880300.0, 0.00141) }, { 0.026000000000000002d, new GammaParticle(948900.0, 0.00131) }, { 0.055d, new GammaParticle(1034600.0, 0.0012) }, { 0.0168d, new GammaParticle(1091200.0, 0.00114) }, { 0.071d, new GammaParticle(1125100.0, 0.0011) }, { 0.008d, new GammaParticle(1134200.0, 0.00109) }, { 0.0059d, new GammaParticle(1228900.0, 0.00101) }, { 0.0285d, new GammaParticle(1316500.0, 0.00094) }, { 0.0044d, new GammaParticle(1455400.0, 0.00085) }, { 0.011699999999999999d, new GammaParticle(1781500.0, 0.0007) }, { 1.5218d, new GammaParticle(511000.0, 0.00243) }, { 0.08837903149082d, new GammaParticle(11777.0, 0.10528) }, { 0.055311658656938455d, new GammaParticle(68894.0, 0.018) }, { 0.0937644662772308d, new GammaParticle(70820.0, 0.01751) }, { 0.03182135381425423d, new GammaParticle(80316.0, 0.01544) }, { 0.04114501048183072d, new GammaParticle(81285.0, 0.01525) }, { 0.00932365666757649d, new GammaParticle(82477.0, 0.01503) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold176() }, { 1.0d, new AlphaParticle(7727002.09) } } },
            { 3.2e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury180() } } },

        };
    }
}
    