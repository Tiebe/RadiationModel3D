using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum110 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum110";
        public override double halfLife { get; } = 0.296d;
        public override double atomicWeight { get; } = 109.93072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium110() }, { 1.0d, new BetaParticle(-1, 3249500.0) }, { 0.04d, new GammaParticle(39400.0, 0.03147) }, { 0.099d, new GammaParticle(53300.0, 0.02326) }, { 0.2065d, new GammaParticle(121000.0, 0.01025) }, { 0.083d, new GammaParticle(131700.0, 0.00941) }, { 0.5d, new GammaParticle(142100.0, 0.00873) }, { 0.01d, new GammaParticle(203600.0, 0.00609) }, { 0.10550000000000001d, new GammaParticle(223400.0, 0.00555) }, { 0.040999999999999995d, new GammaParticle(262900.0, 0.00472) }, { 0.014499999999999999d, new GammaParticle(273000.0, 0.00454) }, { 0.027000000000000003d, new GammaParticle(325700.0, 0.00381) }, { 0.0115d, new GammaParticle(447600.0, 0.00277) }, { 0.128d, new GammaParticle(477800.0, 0.00259) }, { 0.19949999999999998d, new GammaParticle(598400.0, 0.00207) }, { 0.040999999999999995d, new GammaParticle(741100.0, 0.00167) }, { 0.0325d, new GammaParticle(766700.0, 0.00162) }, { 0.013999999999999999d, new GammaParticle(2586.0, 0.47944) }, { 0.067d, new GammaParticle(18250.0, 0.06794) }, { 0.13d, new GammaParticle(18367.0, 0.0675) }, { 0.034d, new GammaParticle(20695.0, 0.05991) }, { 0.039d, new GammaParticle(20820.0, 0.05955) }, { 0.0054d, new GammaParticle(21003.0, 0.05903) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium110() }, { 1.0d, new BetaParticle(-1, 3249500.0) }, { 0.04d, new GammaParticle(39400.0, 0.03147) }, { 0.099d, new GammaParticle(53300.0, 0.02326) }, { 0.2065d, new GammaParticle(121000.0, 0.01025) }, { 0.083d, new GammaParticle(131700.0, 0.00941) }, { 0.5d, new GammaParticle(142100.0, 0.00873) }, { 0.01d, new GammaParticle(203600.0, 0.00609) }, { 0.10550000000000001d, new GammaParticle(223400.0, 0.00555) }, { 0.040999999999999995d, new GammaParticle(262900.0, 0.00472) }, { 0.014499999999999999d, new GammaParticle(273000.0, 0.00454) }, { 0.027000000000000003d, new GammaParticle(325700.0, 0.00381) }, { 0.0115d, new GammaParticle(447600.0, 0.00277) }, { 0.128d, new GammaParticle(477800.0, 0.00259) }, { 0.19949999999999998d, new GammaParticle(598400.0, 0.00207) }, { 0.040999999999999995d, new GammaParticle(741100.0, 0.00167) }, { 0.0325d, new GammaParticle(766700.0, 0.00162) }, { 0.013999999999999999d, new GammaParticle(2586.0, 0.47944) }, { 0.067d, new GammaParticle(18250.0, 0.06794) }, { 0.13d, new GammaParticle(18367.0, 0.0675) }, { 0.034d, new GammaParticle(20695.0, 0.05991) }, { 0.039d, new GammaParticle(20820.0, 0.05955) }, { 0.0054d, new GammaParticle(21003.0, 0.05903) } } },

        };
    }
}
    