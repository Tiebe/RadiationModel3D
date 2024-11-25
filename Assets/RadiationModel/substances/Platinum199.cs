using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum199 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum199";
        public override double halfLife { get; } = 1848.0d;
        public override double atomicWeight { get; } = 198.9706d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold199() }, { 1.0d, new BetaParticle(-1, 852550.00001) }, { 0.000124444d, new GammaParticle(55150.0, 0.02248) }, { 0.0119748d, new GammaParticle(77200.0, 0.01606) }, { 0.0001761d, new GammaParticle(170600.0, 0.00727) }, { 0.00022306d, new GammaParticle(176200.0, 0.00704) }, { 0.027870759999999998d, new GammaParticle(185800.0, 0.00667) }, { 0.01765696d, new GammaParticle(191690.0, 0.00647) }, { 0.0030524000000000003d, new GammaParticle(219360.0, 0.00565) }, { 0.0013031400000000002d, new GammaParticle(225360.0, 0.0055) }, { 0.0012914d, new GammaParticle(240010.0, 0.00517) }, { 0.00046960000000000003d, new GammaParticle(240900.0, 0.00515) }, { 0.01810308d, new GammaParticle(246460.0, 0.00503) }, { 0.00029350000000000003d, new GammaParticle(298200.0, 0.00416) }, { 0.038812440000000004d, new GammaParticle(317030.0, 0.00391) }, { 0.00213668d, new GammaParticle(323600.0, 0.00383) }, { 0.0029937d, new GammaParticle(417610.0, 0.00297) }, { 0.00119748d, new GammaParticle(425340.0, 0.00291) }, { 0.007278799999999999d, new GammaParticle(465760.0, 0.00266) }, { 0.007983200000000001d, new GammaParticle(468090.0, 0.00265) }, { 0.00914546d, new GammaParticle(474680.0, 0.00261) }, { 0.04465896d, new GammaParticle(493750.0, 0.00251) }, { 0.0008218d, new GammaParticle(505500.0, 0.00245) }, { 0.1174d, new GammaParticle(542980.0, 0.00228) }, { 0.000122096d, new GammaParticle(609800.0, 0.00203) }, { 0.0006457d, new GammaParticle(644630.0, 0.00192) }, { 7.396200000000001e-05d, new GammaParticle(649800.0, 0.00191) }, { 0.00045199000000000004d, new GammaParticle(665000.0, 0.00186) }, { 0.014487159999999999d, new GammaParticle(714550.0, 0.00174) }, { 0.00021366799999999997d, new GammaParticle(746400.0, 0.00166) }, { 0.000365114d, new GammaParticle(752900.0, 0.00165) }, { 0.00024067d, new GammaParticle(780500.0, 0.00159) }, { 0.00017962200000000002d, new GammaParticle(786800.0, 0.00158) }, { 0.00830018d, new GammaParticle(791740.0, 0.00157) }, { 0.000191362d, new GammaParticle(835500.0, 0.00148) }, { 0.000138532d, new GammaParticle(842400.0, 0.00147) }, { 0.000189014d, new GammaParticle(891300.0, 0.00139) }, { 8.218e-05d, new GammaParticle(902000.0, 0.00137) }, { 0.0080419d, new GammaParticle(968320.0, 0.00128) }, { 9.979e-05d, new GammaParticle(992300.0, 0.00125) }, { 0.00016083799999999998d, new GammaParticle(1072700.0, 0.00116) }, { 7.5136e-05d, new GammaParticle(1077000.0, 0.00115) }, { 0.00021366799999999997d, new GammaParticle(1104000.0, 0.00112) }, { 8.100599999999999e-05d, new GammaParticle(1159200.0, 0.00107) }, { 9.2746e-05d, new GammaParticle(1249400.0, 0.00099) }, { 0.035d, new GammaParticle(11419.0, 0.10858) }, { 0.00992d, new GammaParticle(66991.0, 0.01851) }, { 0.0169d, new GammaParticle(68806.0, 0.01802) }, { 0.005699999999999999d, new GammaParticle(78048.0, 0.01589) }, { 0.00734d, new GammaParticle(78983.0, 0.0157) }, { 0.00165d, new GammaParticle(80133.0, 0.01547) } } },

        };
    }
}
    