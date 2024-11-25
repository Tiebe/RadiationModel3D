using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium149";
        public override double halfLife { get; } = 8043840.0d;
        public override double atomicWeight { get; } = 148.91794d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium149() }, { 0.0271d, new GammaParticle(22500.2, 0.0551) }, { 0.000165d, new GammaParticle(72983.0, 0.01699) }, { 3.3e-06d, new GammaParticle(122000.0, 0.01016) }, { 4.7e-06d, new GammaParticle(129500.0, 0.00957) }, { 3.7000000000000005e-05d, new GammaParticle(130098.0, 0.00953) }, { 0.000257d, new GammaParticle(178580.0, 0.00694) }, { 0.000145d, new GammaParticle(208283.0, 0.00595) }, { 0.00013d, new GammaParticle(251510.0, 0.00493) }, { 0.0075d, new GammaParticle(254566.0, 0.00487) }, { 1.4999999999999998e-06d, new GammaParticle(272210.0, 0.00455) }, { 0.0418d, new GammaParticle(277089.0, 0.00447) }, { 0.000263d, new GammaParticle(281295.0, 0.00441) }, { 8.1e-06d, new GammaParticle(285950.0, 0.00434) }, { 1.2e-06d, new GammaParticle(308000.0, 0.00403) }, { 0.0475d, new GammaParticle(327526.0, 0.00379) }, { 0.00425d, new GammaParticle(350016.0, 0.00354) }, { 3.3e-07d, new GammaParticle(376500.0, 0.00329) }, { 4.1e-05d, new GammaParticle(381700.0, 0.00325) }, { 0.00645d, new GammaParticle(506093.0, 0.00245) }, { 0.00605d, new GammaParticle(528587.0, 0.00235) }, { 0.000536d, new GammaParticle(535897.0, 0.00231) }, { 0.00063d, new GammaParticle(558372.0, 0.00222) }, { 2.9e-07d, new GammaParticle(568270.0, 0.00218) }, { 1.13e-06d, new GammaParticle(590880.0, 0.0021) }, { 3.06e-06d, new GammaParticle(613915.0, 0.00202) }, { 3.5e-06d, new GammaParticle(636050.0, 0.00195) }, { 1.77e-06d, new GammaParticle(636500.0, 0.00195) }, { 0.235d, new GammaParticle(6354.0, 0.19513) }, { 0.22d, new GammaParticle(39522.0, 0.03137) }, { 0.397d, new GammaParticle(40117.0, 0.03091) }, { 0.124d, new GammaParticle(45523.0, 0.02724) }, { 0.156d, new GammaParticle(45998.0, 0.02695) }, { 0.032d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    