using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium172";
        public override double halfLife { get; } = 177480.0d;
        public override double atomicWeight { get; } = 171.93936d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium172() }, { 1.0d, new BetaParticle(-1, 445500.0) }, { 7.578e-05d, new GammaParticle(29370.0, 0.04221) }, { 7.157000000000001e-05d, new GammaParticle(38660.0, 0.03207) }, { 0.026944d, new GammaParticle(59692.0, 0.02077) }, { 0.0020629d, new GammaParticle(62524.0, 0.01983) }, { 0.0329222d, new GammaParticle(68107.0, 0.0182) }, { 0.0011788d, new GammaParticle(74940.0, 0.01654) }, { 4.21e-05d, new GammaParticle(80190.0, 0.01546) }, { 2.947e-05d, new GammaParticle(83150.0, 0.01491) }, { 4.6309999999999995e-05d, new GammaParticle(89090.0, 0.01392) }, { 1.263e-05d, new GammaParticle(113710.0, 0.0109) }, { 8.419999999999999e-06d, new GammaParticle(118900.0, 0.01043) }, { 0.0212605d, new GammaParticle(127805.0, 0.0097) }, { 0.00010104d, new GammaParticle(134680.0, 0.00921) }, { 1.263e-05d, new GammaParticle(145830.0, 0.0085) }, { 0.006736d, new GammaParticle(164013.0, 0.00756) }, { 7.157000000000001e-05d, new GammaParticle(167400.0, 0.00741) }, { 9.683e-06d, new GammaParticle(177160.0, 0.007) }, { 9.683e-06d, new GammaParticle(179600.0, 0.0069) }, { 8.419999999999999e-06d, new GammaParticle(187400.0, 0.00662) }, { 0.010314499999999999d, new GammaParticle(202724.0, 0.00612) }, { 2.947e-05d, new GammaParticle(206090.0, 0.00602) }, { 4.21e-05d, new GammaParticle(239500.0, 0.00518) }, { 0.00011367d, new GammaParticle(239900.0, 0.00517) }, { 2.526e-05d, new GammaParticle(295300.0, 0.0042) }, { 0.00020629d, new GammaParticle(300190.0, 0.00413) }, { 0.00010104d, new GammaParticle(307150.0, 0.00404) }, { 0.0062729000000000005d, new GammaParticle(344817.0, 0.0036) }, { 1.2209e-05d, new GammaParticle(370300.0, 0.00335) }, { 0.0234918d, new GammaParticle(383501.0, 0.00323) }, { 0.42100000000000004d, new GammaParticle(407338.0, 0.00304) }, { 8.841e-05d, new GammaParticle(416800.0, 0.00297) }, { 0.029554200000000003d, new GammaParticle(446025.0, 0.00278) }, { 2.105e-05d, new GammaParticle(463700.0, 0.00267) }, { 0.00031154d, new GammaParticle(472710.0, 0.00262) }, { 0.0103987d, new GammaParticle(475445.0, 0.00261) }, { 0.00011367d, new GammaParticle(479760.0, 0.00258) }, { 2.526e-05d, new GammaParticle(496300.0, 0.0025) }, { 2.947e-05d, new GammaParticle(526200.0, 0.00236) }, { 0.00293016d, new GammaParticle(535143.0, 0.00232) }, { 2.947e-06d, new GammaParticle(547540.0, 0.00226) }, { 0.44205d, new GammaParticle(610062.0, 0.00203) }, { 1.6839999999999998e-05d, new GammaParticle(714450.0, 0.00174) }, { 1.263e-06d, new GammaParticle(734900.0, 0.00169) }, { 0.00010525d, new GammaParticle(797420.0, 0.00155) }, { 2.1049999999999998e-06d, new GammaParticle(831000.0, 0.00149) }, { 1.263e-05d, new GammaParticle(894000.0, 0.00139) }, { 0.09616335077645821d, new GammaParticle(8215.0, 0.15092) }, { 0.08881850461381412d, new GammaParticle(49773.0, 0.02491) }, { 0.15681233159218594d, new GammaParticle(50742.0, 0.02443) }, { 0.051270563430300016d, new GammaParticle(57612.0, 0.02152) }, { 0.06460090992217801d, new GammaParticle(58257.0, 0.02128) }, { 0.013330346491878002d, new GammaParticle(59034.0, 0.021) } } },

        };
    }
}
    