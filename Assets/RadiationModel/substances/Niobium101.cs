using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium101";
        public override double halfLife { get; } = 7.1d;
        public override double atomicWeight { get; } = 100.91531d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Molybdenum101() }, { 1.0d, new BetaParticle(-1, 2314500.0) }, { 0.21d, new GammaParticle(13490.0, 0.09191) }, { 0.21d, new GammaParticle(43515.0, 0.02849) }, { 0.0021d, new GammaParticle(81200.0, 0.01527) }, { 0.0042d, new GammaParticle(114000.0, 0.01088) }, { 0.0294d, new GammaParticle(118600.0, 0.01045) }, { 0.0672d, new GammaParticle(157500.0, 0.00787) }, { 0.00042d, new GammaParticle(165000.0, 0.00751) }, { 0.01848d, new GammaParticle(180600.0, 0.00687) }, { 0.0054600000000000004d, new GammaParticle(186000.0, 0.00667) }, { 0.00252d, new GammaParticle(217000.0, 0.00571) }, { 0.00147d, new GammaParticle(224000.0, 0.00554) }, { 0.010289999999999999d, new GammaParticle(232600.0, 0.00533) }, { 0.00315d, new GammaParticle(236800.0, 0.00524) }, { 0.00042d, new GammaParticle(237500.0, 0.00522) }, { 0.21d, new GammaParticle(276100.0, 0.00449) }, { 0.00714d, new GammaParticle(280300.0, 0.00442) }, { 0.0069299999999999995d, new GammaParticle(283500.0, 0.00437) }, { 0.021d, new GammaParticle(289600.0, 0.00428) }, { 0.0042d, new GammaParticle(294000.0, 0.00422) }, { 0.0105d, new GammaParticle(294500.0, 0.00421) }, { 0.00189d, new GammaParticle(305200.0, 0.00406) }, { 0.00042d, new GammaParticle(338100.0, 0.00367) }, { 0.00504d, new GammaParticle(351600.0, 0.00353) }, { 0.00168d, new GammaParticle(356300.0, 0.00348) }, { 0.00084d, new GammaParticle(374500.0, 0.00331) }, { 0.00294d, new GammaParticle(397500.0, 0.00312) }, { 0.00588d, new GammaParticle(399300.0, 0.00311) }, { 0.00105d, new GammaParticle(422800.0, 0.00293) }, { 0.0462d, new GammaParticle(441100.0, 0.00281) }, { 0.00357d, new GammaParticle(454500.0, 0.00273) }, { 0.0039900000000000005d, new GammaParticle(459100.0, 0.0027) }, { 0.0378d, new GammaParticle(466300.0, 0.00266) }, { 0.039900000000000005d, new GammaParticle(479800.0, 0.00258) }, { 0.0084d, new GammaParticle(507500.0, 0.00244) }, { 0.0069299999999999995d, new GammaParticle(559700.0, 0.00222) }, { 0.00189d, new GammaParticle(626100.0, 0.00198) }, { 0.00168d, new GammaParticle(639500.0, 0.00194) }, { 0.00672d, new GammaParticle(682900.0, 0.00182) }, { 0.00357d, new GammaParticle(740200.0, 0.00168) }, { 0.00168d, new GammaParticle(753600.0, 0.00165) }, { 0.01554d, new GammaParticle(783500.0, 0.00158) }, { 0.01512d, new GammaParticle(797100.0, 0.00156) }, { 0.00525d, new GammaParticle(810600.0, 0.00153) }, { 0.00294d, new GammaParticle(840500.0, 0.00148) }, { 0.00966d, new GammaParticle(853900.0, 0.00145) }, { 0.00756d, new GammaParticle(1042200.0, 0.00119) }, { 0.00252d, new GammaParticle(1085700.0, 0.00114) }, { 0.18727793004740398d, new GammaParticle(2440.0, 0.50813) }, { 0.41354695982800643d, new GammaParticle(17374.0, 0.07136) }, { 0.7881588714084361d, new GammaParticle(17479.0, 0.07093) }, { 0.20681003300134965d, new GammaParticle(19681.0, 0.063) }, { 0.23865877808355748d, new GammaParticle(19794.0, 0.06264) }, { 0.03184874508220784d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    