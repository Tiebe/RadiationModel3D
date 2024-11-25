using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium28 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium28";
        public override double halfLife { get; } = 0.0305d;
        public override double atomicWeight { get; } = 27.99894d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium28() }, { 1.0d, new BetaParticle(-1, 7015975.0) }, { 0.001d, new GammaParticle(1150500.0, 0.00108) }, { 0.001d, new GammaParticle(1373400.0, 0.0009) }, { 0.37d, new GammaParticle(1473500.0, 0.00084) }, { 0.002d, new GammaParticle(1990700.0, 0.00062) }, { 0.005d, new GammaParticle(2007700.0, 0.00062) }, { 0.008d, new GammaParticle(2191700.0, 0.00057) }, { 0.001d, new GammaParticle(2290900.0, 0.00054) }, { 0.22d, new GammaParticle(2388500.0, 0.00052) }, { 0.001d, new GammaParticle(2547700.0, 0.00049) }, { 0.006d, new GammaParticle(2906900.0, 0.00043) }, { 0.013000000000000001d, new GammaParticle(3082400.0, 0.0004) }, { 0.04d, new GammaParticle(3087300.0, 0.0004) }, { 0.002d, new GammaParticle(3404900.0, 0.00036) }, { 0.003d, new GammaParticle(3696800.0, 0.00034) }, { 0.001d, new GammaParticle(3996300.0, 0.00031) }, { 0.003d, new GammaParticle(4443000.0, 0.00028) }, { 0.004d, new GammaParticle(5192600.0, 0.00024) }, { 0.023d, new GammaParticle(5269600.0, 0.00024) } } },
            { 0.0058d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium28() }, { 1.0d, new BetaParticle(-1, 7015975.0) }, { 0.001d, new GammaParticle(1150500.0, 0.00108) }, { 0.001d, new GammaParticle(1373400.0, 0.0009) }, { 0.37d, new GammaParticle(1473500.0, 0.00084) }, { 0.002d, new GammaParticle(1990700.0, 0.00062) }, { 0.005d, new GammaParticle(2007700.0, 0.00062) }, { 0.008d, new GammaParticle(2191700.0, 0.00057) }, { 0.001d, new GammaParticle(2290900.0, 0.00054) }, { 0.22d, new GammaParticle(2388500.0, 0.00052) }, { 0.001d, new GammaParticle(2547700.0, 0.00049) }, { 0.006d, new GammaParticle(2906900.0, 0.00043) }, { 0.013000000000000001d, new GammaParticle(3082400.0, 0.0004) }, { 0.04d, new GammaParticle(3087300.0, 0.0004) }, { 0.002d, new GammaParticle(3404900.0, 0.00036) }, { 0.003d, new GammaParticle(3696800.0, 0.00034) }, { 0.001d, new GammaParticle(3996300.0, 0.00031) }, { 0.003d, new GammaParticle(4443000.0, 0.00028) }, { 0.004d, new GammaParticle(5192600.0, 0.00024) }, { 0.023d, new GammaParticle(5269600.0, 0.00024) } } },

        };
    }
}
    