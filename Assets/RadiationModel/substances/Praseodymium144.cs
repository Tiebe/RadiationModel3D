using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium144";
        public override double halfLife { get; } = 1036.8d;
        public override double atomicWeight { get; } = 143.91331d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium144() }, { 1.0d, new BetaParticle(-1, 1498700.0) }, { 1.12728e-05d, new GammaParticle(624700.0, 0.00198) }, { 2.9524e-05d, new GammaParticle(674950.0, 0.00184) }, { 0.013420000000000001d, new GammaParticle(696510.0, 0.00178) }, { 3.2208e-05d, new GammaParticle(814100.0, 0.00152) }, { 2.4156e-05d, new GammaParticle(864450.0, 0.00143) }, { 5.368e-07d, new GammaParticle(1182000.0, 0.00105) }, { 3.8918e-06d, new GammaParticle(1376270.0, 0.0009) }, { 6.72342e-05d, new GammaParticle(1388020.0, 0.00089) }, { 0.00277794d, new GammaParticle(1489160.0, 0.00083) }, { 2.013e-06d, new GammaParticle(1560970.0, 0.00079) }, { 8.723e-06d, new GammaParticle(1978820.0, 0.00063) }, { 2.684e-06d, new GammaParticle(2046300.0, 0.00061) }, { 2.2814e-06d, new GammaParticle(2072900.0, 0.0006) }, { 0.006938140000000001d, new GammaParticle(2185662.0, 0.00057) }, { 5.368e-07d, new GammaParticle(2368300.0, 0.00052) }, { 1.4762e-06d, new GammaParticle(2654900.0, 0.00047) }, { 8.31020311140712e-06d, new GammaParticle(5870.0, 0.21122) }, { 1.526274888959933e-05d, new GammaParticle(36848.0, 0.03365) }, { 2.7795936786740726e-05d, new GammaParticle(37362.0, 0.03318) }, { 8.53637587155445e-06d, new GammaParticle(42380.0, 0.02926) }, { 1.0730224470543943e-05d, new GammaParticle(42810.0, 0.02896) }, { 2.1938485989894937e-06d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    