using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium61 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium61";
        public override double halfLife { get; } = 0.167d;
        public override double atomicWeight { get; } = 60.9494d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper61() }, { 1.0d, new BetaParticle(1, 7427050.0) }, { 0.019d, new GammaParticle(87600.0, 0.01415) }, { 0.011779999999999999d, new GammaParticle(122900.0, 0.01009) }, { 0.00037999999999999997d, new GammaParticle(295500.0, 0.0042) }, { 0.0007599999999999999d, new GammaParticle(330000.0, 0.00376) }, { 0.00037999999999999997d, new GammaParticle(337500.0, 0.00367) }, { 0.013680000000000001d, new GammaParticle(418400.0, 0.00296) }, { 0.0017100000000000001d, new GammaParticle(520000.0, 0.00238) }, { 0.00018999999999999998d, new GammaParticle(633000.0, 0.00196) }, { 0.00836d, new GammaParticle(754500.0, 0.00164) }, { 0.00114d, new GammaParticle(850000.0, 0.00146) }, { 0.0039900000000000005d, new GammaParticle(938000.0, 0.00132) }, { 9.499999999999999e-05d, new GammaParticle(1362000.0, 0.00091) }, { 1.9969999999999999d, new GammaParticle(511000.0, 0.00243) }, { 5.7e-05d, new GammaParticle(1035.0, 1.19791) }, { 0.00053d, new GammaParticle(8616.0, 0.1439) }, { 0.0010299999999999999d, new GammaParticle(8639.0, 0.14352) }, { 0.00021999999999999998d, new GammaParticle(9610.0, 0.12902) }, { 0.00021999999999999998d, new GammaParticle(9610.0, 0.12902) } } },
            { 0.0025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper60() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    