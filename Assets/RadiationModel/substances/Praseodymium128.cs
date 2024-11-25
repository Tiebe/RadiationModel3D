using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium128 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium128";
        public override double halfLife { get; } = 2.84d;
        public override double atomicWeight { get; } = 127.92879d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lanthanum128() }, { 1.0d, new BetaParticle(1, 6149500.0) }, { 0.8590000000000001d, new GammaParticle(207300.0, 0.00598) }, { 0.26d, new GammaParticle(399700.0, 0.0031) }, { 0.034d, new GammaParticle(550600.0, 0.00225) }, { 0.048d, new GammaParticle(662400.0, 0.00187) }, { 0.011000000000000001d, new GammaParticle(699400.0, 0.00177) }, { 0.015d, new GammaParticle(705200.0, 0.00176) }, { 0.018000000000000002d, new GammaParticle(731800.0, 0.00169) }, { 0.11199999999999999d, new GammaParticle(845300.0, 0.00147) }, { 0.04d, new GammaParticle(931600.0, 0.00133) }, { 7.1e-05d, new GammaParticle(1052000.0, 0.00118) }, { 0.013999999999999999d, new GammaParticle(1094100.0, 0.00113) }, { 0.028999999999999998d, new GammaParticle(1099000.0, 0.00113) }, { 0.024d, new GammaParticle(1372800.0, 0.0009) }, { 1.9369999999999998d, new GammaParticle(511000.0, 0.00243) }, { 0.01880424395d, new GammaParticle(5410.0, 0.22918) }, { 0.035417765021954185d, new GammaParticle(34279.0, 0.03617) }, { 0.0648677015054106d, new GammaParticle(34720.0, 0.03571) }, { 0.01953727230672665d, new GammaParticle(39366.0, 0.0315) }, { 0.02449973947263522d, new GammaParticle(39753.0, 0.03119) }, { 0.004962467165908569d, new GammaParticle(40229.0, 0.03082) } } },

        };
    }
}
    