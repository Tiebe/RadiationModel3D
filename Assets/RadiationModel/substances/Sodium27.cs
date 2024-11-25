using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium27 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium27";
        public override double halfLife { get; } = 0.301d;
        public override double atomicWeight { get; } = 26.99408d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium27() }, { 1.0d, new BetaParticle(-1, 4534295.0) }, { 0.00874d, new GammaParticle(955340.0, 0.0013) }, { 0.8740000000000001d, new GammaParticle(984660.0, 0.00126) }, { 0.005943199999999999d, new GammaParticle(1169400.0, 0.00106) }, { 0.0009614000000000001d, new GammaParticle(1666700.0, 0.00074) }, { 0.118864d, new GammaParticle(1698000.0, 0.00073) }, { 0.0032338d, new GammaParticle(1728900.0, 0.00072) }, { 0.0014857999999999998d, new GammaParticle(1792700.0, 0.00069) }, { 0.0046322d, new GammaParticle(1940000.0, 0.00064) }, { 0.0041952d, new GammaParticle(2442300.0, 0.00051) }, { 0.0002622d, new GammaParticle(2451800.0, 0.00051) }, { 0.0025346d, new GammaParticle(2506000.0, 0.00049) }, { 0.0017480000000000002d, new GammaParticle(2612800.0, 0.00047) }, { 0.00063802d, new GammaParticle(2836100.0, 0.00044) }, { 0.0012236d, new GammaParticle(3490700.0, 0.00036) }, { 0.0018354d, new GammaParticle(4007600.0, 0.00031) } } },
            { 0.0013d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Magnesium27() }, { 1.0d, new BetaParticle(-1, 4534295.0) }, { 0.00874d, new GammaParticle(955340.0, 0.0013) }, { 0.8740000000000001d, new GammaParticle(984660.0, 0.00126) }, { 0.005943199999999999d, new GammaParticle(1169400.0, 0.00106) }, { 0.0009614000000000001d, new GammaParticle(1666700.0, 0.00074) }, { 0.118864d, new GammaParticle(1698000.0, 0.00073) }, { 0.0032338d, new GammaParticle(1728900.0, 0.00072) }, { 0.0014857999999999998d, new GammaParticle(1792700.0, 0.00069) }, { 0.0046322d, new GammaParticle(1940000.0, 0.00064) }, { 0.0041952d, new GammaParticle(2442300.0, 0.00051) }, { 0.0002622d, new GammaParticle(2451800.0, 0.00051) }, { 0.0025346d, new GammaParticle(2506000.0, 0.00049) }, { 0.0017480000000000002d, new GammaParticle(2612800.0, 0.00047) }, { 0.00063802d, new GammaParticle(2836100.0, 0.00044) }, { 0.0012236d, new GammaParticle(3490700.0, 0.00036) }, { 0.0018354d, new GammaParticle(4007600.0, 0.00031) } } },

        };
    }
}
    