using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver113 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver113";
        public override double halfLife { get; } = 19332.0d;
        public override double atomicWeight { get; } = 112.90657d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium113() }, { 1.0d, new BetaParticle(-1, 1008145.0) }, { 0.00042d, new GammaParticle(17700.0, 0.07005) }, { 0.00037d, new GammaParticle(96200.0, 0.01289) }, { 0.00066d, new GammaParticle(133500.0, 0.00929) }, { 0.0002d, new GammaParticle(206400.0, 0.00601) }, { 0.00028000000000000003d, new GammaParticle(217200.0, 0.00571) }, { 0.01635d, new GammaParticle(258800.0, 0.00479) }, { 0.1d, new GammaParticle(298600.0, 0.00415) }, { 0.01343d, new GammaParticle(316300.0, 0.00392) }, { 0.00598d, new GammaParticle(333100.0, 0.00372) }, { 0.00638d, new GammaParticle(339400.0, 0.00365) }, { 0.0014000000000000002d, new GammaParticle(364400.0, 0.0034) }, { 0.0001d, new GammaParticle(369000.0, 0.00336) }, { 0.00025d, new GammaParticle(374300.0, 0.00331) }, { 0.00145d, new GammaParticle(382100.0, 0.00324) }, { 0.0002d, new GammaParticle(392400.0, 0.00316) }, { 0.00012d, new GammaParticle(410800.0, 0.00302) }, { 8e-05d, new GammaParticle(539000.0, 0.0023) }, { 0.0021d, new GammaParticle(584000.0, 0.00212) }, { 0.0001d, new GammaParticle(585000.0, 0.00212) }, { 0.00045d, new GammaParticle(611000.0, 0.00203) }, { 0.00018999999999999998d, new GammaParticle(624000.0, 0.00199) }, { 0.0003d, new GammaParticle(672300.0, 0.00184) }, { 0.0087d, new GammaParticle(672300.0, 0.00184) }, { 0.00695d, new GammaParticle(680600.0, 0.00182) }, { 0.0001d, new GammaParticle(734000.0, 0.00169) }, { 0.00015d, new GammaParticle(809900.0, 0.00153) }, { 0.00010999999999999999d, new GammaParticle(816100.0, 0.00152) }, { 0.0001d, new GammaParticle(827000.0, 0.0015) }, { 0.00052d, new GammaParticle(878500.0, 0.00141) }, { 0.0028199999999999996d, new GammaParticle(883600.0, 0.0014) }, { 0.00058d, new GammaParticle(896100.0, 0.00138) }, { 0.00423d, new GammaParticle(988400.0, 0.00125) }, { 0.00045d, new GammaParticle(1049900.0, 0.00118) }, { 0.00016d, new GammaParticle(1084500.0, 0.00114) }, { 0.00061d, new GammaParticle(1126100.0, 0.0011) }, { 0.00037d, new GammaParticle(1180800.0, 0.00105) }, { 0.00378d, new GammaParticle(1194600.0, 0.00104) }, { 0.00068d, new GammaParticle(1479200.0, 0.00084) }, { 0.0004821092360504d, new GammaParticle(3388.0, 0.36595) }, { 0.0009371679522622738d, new GammaParticle(22983.0, 0.05395) }, { 0.0017625878357387134d, new GammaParticle(23173.0, 0.0535) }, { 0.0004913007360397737d, new GammaParticle(26184.0, 0.04735) }, { 0.0005807174699990125d, new GammaParticle(26381.0, 0.047) }, { 8.941673395923879e-05d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    