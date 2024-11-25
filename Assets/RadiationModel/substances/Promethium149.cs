using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium149";
        public override double halfLife { get; } = 191088.0d;
        public override double atomicWeight { get; } = 148.91834d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium149() }, { 1.0d, new BetaParticle(-1, 535750.0) }, { 0.000496d, new GammaParticle(22500.2, 0.0551) }, { 3.1e-07d, new GammaParticle(72980.0, 0.01699) }, { 1.4599999999999999e-05d, new GammaParticle(208280.0, 0.00595) }, { 2.17e-06d, new GammaParticle(238380.0, 0.0052) }, { 1.86e-06d, new GammaParticle(242100.0, 0.00512) }, { 5.3e-05d, new GammaParticle(254570.0, 0.00487) }, { 3.4e-06d, new GammaParticle(257770.0, 0.00481) }, { 9.599999999999999e-05d, new GammaParticle(263230.0, 0.00471) }, { 0.000288d, new GammaParticle(277090.0, 0.00447) }, { 7.400000000000001e-05d, new GammaParticle(281240.0, 0.00441) }, { 0.031d, new GammaParticle(285950.0, 0.00434) }, { 2.5699999999999998e-05d, new GammaParticle(305220.0, 0.00406) }, { 2.8e-06d, new GammaParticle(314850.0, 0.00394) }, { 1.52e-05d, new GammaParticle(323950.0, 0.00383) }, { 3.72e-05d, new GammaParticle(327530.0, 0.00379) }, { 3.44e-06d, new GammaParticle(350000.0, 0.00354) }, { 1.49e-05d, new GammaParticle(350710.0, 0.00354) }, { 3.1e-06d, new GammaParticle(353460.0, 0.00351) }, { 1.49e-05d, new GammaParticle(359570.0, 0.00345) }, { 1.24e-06d, new GammaParticle(506100.0, 0.00245) }, { 1.24e-06d, new GammaParticle(528600.0, 0.00235) }, { 1.49e-05d, new GammaParticle(531610.0, 0.00233) }, { 0.000115d, new GammaParticle(535900.0, 0.00231) }, { 2.48e-05d, new GammaParticle(544270.0, 0.00228) }, { 1.6100000000000002e-05d, new GammaParticle(547170.0, 0.00227) }, { 1.86e-06d, new GammaParticle(550010.0, 0.00225) }, { 5.9e-06d, new GammaParticle(552920.0, 0.00224) }, { 0.000152d, new GammaParticle(558370.0, 0.00222) }, { 0.000186d, new GammaParticle(568360.0, 0.00218) }, { 2.42e-05d, new GammaParticle(571080.0, 0.00217) }, { 0.0006900000000000001d, new GammaParticle(590880.0, 0.0021) }, { 2.17e-06d, new GammaParticle(598420.0, 0.00207) }, { 0.000149d, new GammaParticle(613920.0, 0.00202) }, { 9.3e-05d, new GammaParticle(636500.0, 0.00195) }, { 7.8e-06d, new GammaParticle(664400.0, 0.00187) }, { 3.7e-06d, new GammaParticle(785230.0, 0.00158) }, { 0.000164d, new GammaParticle(808110.0, 0.00153) }, { 3.1e-06d, new GammaParticle(812920.0, 0.00153) }, { 1.24e-06d, new GammaParticle(824300.0, 0.0015) }, { 0.000325d, new GammaParticle(830530.0, 0.00149) }, { 0.000332d, new GammaParticle(833400.0, 0.00149) }, { 1.08e-05d, new GammaParticle(835550.0, 0.00148) }, { 0.00108d, new GammaParticle(859460.0, 0.00144) }, { 0.000239d, new GammaParticle(881980.0, 0.00141) }, { 9.300000000000001e-08d, new GammaParticle(915500.0, 0.00135) }, { 5.9e-06d, new GammaParticle(930200.0, 0.00133) }, { 2.2e-06d, new GammaParticle(950600.0, 0.0013) }, { 8.7e-06d, new GammaParticle(952800.0, 0.0013) }, { 3.1e-08d, new GammaParticle(964400.0, 0.00129) }, { 3.1e-08d, new GammaParticle(969600.0, 0.00128) }, { 0.0013d, new GammaParticle(6354.0, 0.19513) }, { 0.0006521099949942774d, new GammaParticle(39522.0, 0.03137) }, { 0.0011802895837000494d, new GammaParticle(40117.0, 0.03091) }, { 0.0003689561313857496d, new GammaParticle(45523.0, 0.02724) }, { 0.00046414681328327295d, new GammaParticle(45998.0, 0.02695) }, { 9.51906818975234e-05d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    