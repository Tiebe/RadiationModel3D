using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium148";
        public override double halfLife { get; } = 463795.2d;
        public override double atomicWeight { get; } = 147.91748d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium148() }, { 1.0d, new BetaParticle(-1, 1235050.0) }, { 0.0003774d, new GammaParticle(303590.0, 0.00408) }, { 2.22e-05d, new GammaParticle(362800.0, 0.00342) }, { 0.0001554d, new GammaParticle(393800.0, 0.00315) }, { 0.220002d, new GammaParticle(550270.0, 0.00225) }, { 0.0035298d, new GammaParticle(592830.0, 0.00209) }, { 0.010212d, new GammaParticle(611260.0, 0.00203) }, { 0.0001332d, new GammaParticle(819270.0, 0.00151) }, { 0.0023532d, new GammaParticle(874180.0, 0.00142) }, { 0.0098124d, new GammaParticle(896420.0, 0.00138) }, { 0.0004218d, new GammaParticle(903940.0, 0.00137) }, { 0.114552d, new GammaParticle(914850.0, 0.00136) }, { 0.000222d, new GammaParticle(1113880.0, 0.00111) }, { 2.886e-05d, new GammaParticle(1152500.0, 0.00108) }, { 0.00013764d, new GammaParticle(1371300.0, 0.0009) }, { 0.0005106d, new GammaParticle(1454210.0, 0.00085) }, { 0.222d, new GammaParticle(1465120.0, 0.00085) }, { 5.55e-05d, new GammaParticle(1507680.0, 0.00082) }, { 0.00011322d, new GammaParticle(1664150.0, 0.00075) }, { 0.00038628d, new GammaParticle(1734120.0, 0.00071) }, { 6.216e-05d, new GammaParticle(1763700.0, 0.0007) }, { 0.000444d, new GammaParticle(2284390.0, 0.00054) }, { 2.22e-06d, new GammaParticle(2314000.0, 0.00054) }, { 0.00034262080488260655d, new GammaParticle(6354.0, 0.19513) }, { 0.0005606207491090167d, new GammaParticle(39522.0, 0.03137) }, { 0.0010146981884326094d, new GammaParticle(40117.0, 0.03091) }, { 0.0003171925968833814d, new GammaParticle(45523.0, 0.02724) }, { 0.00039902828687929387d, new GammaParticle(45998.0, 0.02695) }, { 8.18356899959124e-05d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    