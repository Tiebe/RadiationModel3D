using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead200 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead200";
        public override double halfLife { get; } = 77400.0d;
        public override double atomicWeight { get; } = 199.97182d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium200() }, { 0.00028000000000000003d, new GammaParticle(32740.0, 0.03787) }, { 0.0049d, new GammaParticle(109540.0, 0.01132) }, { 0.0319d, new GammaParticle(142280.0, 0.00871) }, { 0.381d, new GammaParticle(147630.0, 0.0084) }, { 0.00047d, new GammaParticle(155290.0, 0.00798) }, { 0.00306d, new GammaParticle(161320.0, 0.00769) }, { 0.00034d, new GammaParticle(193390.0, 0.00641) }, { 0.0434d, new GammaParticle(235620.0, 0.00526) }, { 0.0451d, new GammaParticle(257190.0, 0.00482) }, { 0.04d, new GammaParticle(268360.0, 0.00462) }, { 0.0108d, new GammaParticle(289240.0, 0.00429) }, { 0.0175d, new GammaParticle(289920.0, 0.00428) }, { 0.00168d, new GammaParticle(302930.0, 0.00409) }, { 0.0022500000000000003d, new GammaParticle(315600.0, 0.00393) }, { 0.0016d, new GammaParticle(348230.0, 0.00356) }, { 0.00027d, new GammaParticle(377920.0, 0.00328) }, { 0.0336d, new GammaParticle(450560.0, 0.00275) }, { 0.0011799999999999998d, new GammaParticle(457800.0, 0.00271) }, { 0.00424d, new GammaParticle(525540.0, 0.00236) }, { 0.005699999999999999d, new GammaParticle(605440.0, 0.00205) }, { 0.498d, new GammaParticle(12148.0, 0.10206) }, { 0.302d, new GammaParticle(70832.0, 0.0175) }, { 0.511d, new GammaParticle(72874.0, 0.01701) }, { 0.174d, new GammaParticle(82629.0, 0.015) }, { 0.225d, new GammaParticle(83631.0, 0.01483) }, { 0.0516d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    