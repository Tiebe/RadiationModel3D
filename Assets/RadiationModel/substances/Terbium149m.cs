using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium149m";
        public override double halfLife { get; } = 250.2d;
        public override double atomicWeight { get; } = 148.92329d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9997799999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium149() }, { 1.0d, new BetaParticle(1, 2494000.0) }, { 0.012607d, new GammaParticle(75000.0, 0.01653) }, { 0.073d, new GammaParticle(165000.0, 0.00751) }, { 0.0281d, new GammaParticle(630700.0, 0.00197) }, { 0.3258d, new GammaParticle(651000.0, 0.0019) }, { 0.03394d, new GammaParticle(773000.0, 0.0016) }, { 0.9698d, new GammaParticle(796000.0, 0.00156) }, { 0.011637d, new GammaParticle(853000.0, 0.00145) }, { 0.019396d, new GammaParticle(988000.0, 0.00125) }, { 0.024245000000000003d, new GammaParticle(1681400.0, 0.00074) }, { 0.42d, new GammaParticle(511000.0, 0.00243) }, { 0.1228345652776d, new GammaParticle(6858.0, 0.18079) }, { 0.18460069619420227d, new GammaParticle(42308.0, 0.02931) }, { 0.33207536642238217d, new GammaParticle(42996.0, 0.02884) }, { 0.10497155793144546d, new GammaParticle(48802.0, 0.02541) }, { 0.13257907766741558d, new GammaParticle(49326.0, 0.02514) }, { 0.027607519735970153d, new GammaParticle(49957.0, 0.02482) } } },
            { 0.00021999999999999998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium145() }, { 1.0d, new AlphaParticle(5136002.09) } } },

        };
    }
}
    