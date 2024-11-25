using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium135";
        public override double halfLife { get; } = 744.0d;
        public override double atomicWeight { get; } = 134.91818d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium135() }, { 1.0d, new BetaParticle(1, 4201000.0) }, { 0.2232d, new GammaParticle(41480.0, 0.02989) }, { 0.044640000000000006d, new GammaParticle(112620.0, 0.01101) }, { 0.03968d, new GammaParticle(164700.0, 0.00753) }, { 0.027280000000000002d, new GammaParticle(185070.0, 0.0067) }, { 0.496d, new GammaParticle(204090.0, 0.00607) }, { 0.029759999999999998d, new GammaParticle(206000.0, 0.00602) }, { 0.0069440000000000005d, new GammaParticle(221000.0, 0.00561) }, { 0.0124d, new GammaParticle(233400.0, 0.00531) }, { 0.033728d, new GammaParticle(245400.0, 0.00505) }, { 0.001984d, new GammaParticle(247500.0, 0.00501) }, { 0.026288d, new GammaParticle(256100.0, 0.00484) }, { 0.0074399999999999996d, new GammaParticle(259800.0, 0.00477) }, { 0.024304000000000003d, new GammaParticle(271900.0, 0.00456) }, { 0.010912d, new GammaParticle(316700.0, 0.00391) }, { 0.005952d, new GammaParticle(322600.0, 0.00384) }, { 0.00992d, new GammaParticle(351600.0, 0.00353) }, { 0.022320000000000003d, new GammaParticle(372800.0, 0.00333) }, { 0.014384d, new GammaParticle(385900.0, 0.00321) }, { 0.010912d, new GammaParticle(415000.0, 0.00299) }, { 0.142848d, new GammaParticle(441100.0, 0.00281) }, { 0.00992d, new GammaParticle(442700.0, 0.0028) }, { 0.04216d, new GammaParticle(451900.0, 0.00274) }, { 0.08184d, new GammaParticle(475800.0, 0.00261) }, { 0.016864d, new GammaParticle(482600.0, 0.00257) }, { 0.008432d, new GammaParticle(490300.0, 0.00253) }, { 0.014384d, new GammaParticle(493400.0, 0.00251) }, { 0.096224d, new GammaParticle(501600.0, 0.00247) }, { 0.019344d, new GammaParticle(531900.0, 0.00233) }, { 0.005456d, new GammaParticle(572000.0, 0.00217) }, { 0.037696d, new GammaParticle(593700.0, 0.00209) }, { 0.018848d, new GammaParticle(616500.0, 0.00201) }, { 0.00496d, new GammaParticle(670600.0, 0.00185) }, { 0.007936d, new GammaParticle(708400.0, 0.00175) }, { 0.007936d, new GammaParticle(739400.0, 0.00168) }, { 0.0074399999999999996d, new GammaParticle(746100.0, 0.00166) }, { 0.005952d, new GammaParticle(777700.0, 0.00159) }, { 0.025792000000000002d, new GammaParticle(966600.0, 0.00128) }, { 0.010912d, new GammaParticle(1172100.0, 0.00106) }, { 0.011408d, new GammaParticle(1480700.0, 0.00084) }, { 0.0074399999999999996d, new GammaParticle(1586000.0, 0.00078) }, { 0.01984d, new GammaParticle(1752000.0, 0.00071) }, { 1.31d, new GammaParticle(511000.0, 0.00243) }, { 0.16699999999999998d, new GammaParticle(5637.0, 0.21995) }, { 0.175d, new GammaParticle(35551.0, 0.03488) }, { 0.32d, new GammaParticle(36027.0, 0.03441) }, { 0.09699999999999999d, new GammaParticle(40857.0, 0.03035) }, { 0.122d, new GammaParticle(41266.0, 0.03005) }, { 0.024900000000000002d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    