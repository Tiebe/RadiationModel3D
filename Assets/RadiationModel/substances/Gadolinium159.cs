using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium159";
        public override double halfLife { get; } = 66524.4d;
        public override double atomicWeight { get; } = 158.9264d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium159() }, { 1.0d, new BetaParticle(-1, 485349.99999) }, { 0.0248558d, new GammaParticle(58000.0, 0.02138) }, { 0.000467666d, new GammaParticle(79513.2, 0.01559) }, { 6.467220000000001e-05d, new GammaParticle(137515.0, 0.00902) }, { 0.00020025999999999998d, new GammaParticle(210783.0, 0.00588) }, { 0.002169876d, new GammaParticle(226040.6, 0.00549) }, { 7.69234e-05d, new GammaParticle(237341.0, 0.00522) }, { 7.068000000000001e-06d, new GammaParticle(273620.0, 0.00453) }, { 5.6544000000000006e-05d, new GammaParticle(274163.0, 0.00452) }, { 0.000322772d, new GammaParticle(290286.5, 0.00427) }, { 0.000619628d, new GammaParticle(305549.2, 0.00406) }, { 0.0023925179999999997d, new GammaParticle(348280.7, 0.00356) }, { 0.11779999999999999d, new GammaParticle(363543.0, 0.00341) }, { 2.42668e-06d, new GammaParticle(479840.0, 0.00258) }, { 1.60208e-05d, new GammaParticle(536780.0, 0.00231) }, { 0.000221464d, new GammaParticle(559623.0, 0.00222) }, { 0.00068324d, new GammaParticle(580808.0, 0.00213) }, { 1.8848e-05d, new GammaParticle(616233.0, 0.00201) }, { 0.00015903d, new GammaParticle(617615.0, 0.00201) }, { 3.15704e-06d, new GammaParticle(674260.0, 0.00184) }, { 1.8023400000000001e-06d, new GammaParticle(753740.0, 0.00164) }, { 2.4620200000000002e-05d, new GammaParticle(854947.0, 0.00145) }, { 0.041968828290531605d, new GammaParticle(7118.0, 0.17418) }, { 0.058999604389243385d, new GammaParticle(43743.0, 0.02834) }, { 0.10579093489195515d, new GammaParticle(44481.0, 0.02787) }, { 0.03378271500276199d, new GammaParticle(50494.0, 0.02455) }, { 0.04253243818847734d, new GammaParticle(51040.0, 0.02429) }, { 0.008749723185715355d, new GammaParticle(51699.0, 0.02398) } } },

        };
    }
}
    