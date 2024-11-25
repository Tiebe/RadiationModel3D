using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium238";
        public override double halfLife { get; } = 181353.6d;
        public override double atomicWeight { get; } = 238.05094d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium238() }, { 1.0d, new BetaParticle(-1, 645750.0) }, { 0.000993425d, new GammaParticle(44060.0, 0.02814) }, { 0.00243955d, new GammaParticle(101880.0, 0.01217) }, { 5.0299999999999996e-05d, new GammaParticle(114400.0, 0.01084) }, { 0.0010563d, new GammaParticle(120090.0, 0.01032) }, { 2.38925e-05d, new GammaParticle(132770.0, 0.00934) }, { 1.006e-05d, new GammaParticle(157420.0, 0.00788) }, { 0.000228865d, new GammaParticle(174080.0, 0.00712) }, { 3.0683e-05d, new GammaParticle(220870.0, 0.00561) }, { 0.00010814499999999999d, new GammaParticle(301370.0, 0.00411) }, { 8.2995e-05d, new GammaParticle(319260.0, 0.00388) }, { 1.2072e-05d, new GammaParticle(321800.0, 0.00385) }, { 0.00014586999999999998d, new GammaParticle(324070.0, 0.00383) }, { 2.2635e-06d, new GammaParticle(336380.0, 0.00369) }, { 0.000503d, new GammaParticle(357680.0, 0.00347) }, { 3.018e-05d, new GammaParticle(378100.0, 0.00328) }, { 0.00010814499999999999d, new GammaParticle(380330.0, 0.00326) }, { 0.00021628999999999998d, new GammaParticle(421050.0, 0.00294) }, { 3.018e-05d, new GammaParticle(459800.0, 0.0027) }, { 0.000369705d, new GammaParticle(515530.0, 0.0024) }, { 0.001053785d, new GammaParticle(561170.0, 0.00221) }, { 0.0007746200000000001d, new GammaParticle(605180.0, 0.00205) }, { 7.544999999999999e-05d, new GammaParticle(617410.0, 0.00201) }, { 0.000676535d, new GammaParticle(617410.0, 0.00201) }, { 0.000238925d, new GammaParticle(836880.0, 0.00148) }, { 0.00802285d, new GammaParticle(882630.0, 0.0014) }, { 0.00040239999999999997d, new GammaParticle(885000.0, 0.0014) }, { 8.048e-05d, new GammaParticle(897550.0, 0.00138) }, { 0.0052815d, new GammaParticle(918700.0, 0.00135) }, { 0.02597995d, new GammaParticle(923990.0, 0.00134) }, { 0.0006539d, new GammaParticle(924000.0, 0.00134) }, { 0.0035964499999999997d, new GammaParticle(936600.0, 0.00132) }, { 0.000294255d, new GammaParticle(938850.0, 0.00132) }, { 0.0049797d, new GammaParticle(941410.0, 0.00132) }, { 0.0064383999999999995d, new GammaParticle(962760.0, 0.00129) }, { 8.048e-05d, new GammaParticle(968200.0, 0.00128) }, { 0.0006790499999999999d, new GammaParticle(983000.0, 0.00126) }, { 0.2515d, new GammaParticle(984450.0, 0.00126) }, { 0.087522d, new GammaParticle(1025870.0, 0.00121) }, { 0.1823375d, new GammaParticle(1028530.0, 0.00121) }, { 0.31476071034398534d, new GammaParticle(17604.0, 0.07043) }, { 0.0016464859130375248d, new GammaParticle(99533.0, 0.01246) }, { 0.0026064364619875335d, new GammaParticle(103741.0, 0.01195) }, { 0.0009566707346938327d, new GammaParticle(117130.0, 0.01059) }, { 0.0012886354796325928d, new GammaParticle(118619.0, 0.01045) }, { 0.0003319647449387599d, new GammaParticle(120544.0, 0.01029) } } },

        };
    }
}
    