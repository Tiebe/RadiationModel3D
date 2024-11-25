using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur40 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur40";
        public override double halfLife { get; } = 8.8d;
        public override double atomicWeight { get; } = 39.97548d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chlorine40() }, { 1.0d, new BetaParticle(-1, 2361000.0) }, { 0.52d, new GammaParticle(211590.0, 0.00586) }, { 0.06552d, new GammaParticle(403700.0, 0.00307) }, { 0.2548d, new GammaParticle(431570.0, 0.00287) }, { 0.04003999999999999d, new GammaParticle(457400.0, 0.00271) }, { 0.2704d, new GammaParticle(677410.0, 0.00183) }, { 0.049400000000000006d, new GammaParticle(705200.0, 0.00176) }, { 0.1092d, new GammaParticle(889040.0, 0.00139) }, { 0.2444d, new GammaParticle(1013570.0, 0.00122) }, { 0.19760000000000003d, new GammaParticle(1081330.0, 0.00115) }, { 0.08528000000000001d, new GammaParticle(1292870.0, 0.00096) }, { 0.04992d, new GammaParticle(1786600.0, 0.00069) }, { 0.2184d, new GammaParticle(1874410.0, 0.00066) } } },

        };
    }
}
    