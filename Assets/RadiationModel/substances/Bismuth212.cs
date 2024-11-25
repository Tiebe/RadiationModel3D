using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth212 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth212";
        public override double halfLife { get; } = 3633.0d;
        public override double atomicWeight { get; } = 211.99129d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6406000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium212() }, { 1.0d, new BetaParticle(-1, 1125750.0) }, { 3.2e-05d, new GammaParticle(180200.0, 0.00688) }, { 0.0667d, new GammaParticle(727330.0, 0.0017) }, { 0.01102d, new GammaParticle(785370.0, 0.00158) }, { 0.00378d, new GammaParticle(893408.0, 0.00139) }, { 0.0017000000000000001d, new GammaParticle(952120.0, 0.0013) }, { 0.00016d, new GammaParticle(1073600.0, 0.00115) }, { 0.005639999999999999d, new GammaParticle(1078620.0, 0.00115) }, { 0.0029d, new GammaParticle(1512700.0, 0.00082) }, { 0.0147d, new GammaParticle(1620500.0, 0.00077) }, { 0.00058d, new GammaParticle(1679700.0, 0.00074) }, { 0.0009d, new GammaParticle(1806000.0, 0.00069) }, { 0.000564357256645d, new GammaParticle(13292.0, 0.09328) }, { 0.00038966863512450515d, new GammaParticle(76862.0, 0.01613) }, { 0.0006489069693996756d, new GammaParticle(79290.0, 0.01564) }, { 0.00022340070211732954d, new GammaParticle(89837.0, 0.0138) }, { 0.000292878320475819d, new GammaParticle(90941.0, 0.01363) }, { 6.947761835848948e-05d, new GammaParticle(92315.0, 0.01343) } } },
            { 0.3594d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium208() }, { 1.0d, new AlphaParticle(7229202.09) }, { 0.0106d, new GammaParticle(39857.0, 0.03111) }, { 0.00337d, new GammaParticle(288200.0, 0.0043) }, { 0.00125d, new GammaParticle(328030.0, 0.00378) }, { 0.00017d, new GammaParticle(433700.0, 0.00286) }, { 0.00363d, new GammaParticle(452980.0, 0.00274) }, { 0.0005d, new GammaParticle(473000.0, 0.00262) }, { 3.594e-05d, new GammaParticle(493300.0, 0.00251) }, { 3.5940000000000002e-06d, new GammaParticle(576000.0, 0.00215) }, { 1.0782000000000001e-05d, new GammaParticle(620000.0, 0.002) }, { 0.06998779634612d, new GammaParticle(12148.0, 0.10206) }, { 0.0005480336682326407d, new GammaParticle(70832.0, 0.0175) }, { 0.0009251074750719797d, new GammaParticle(72874.0, 0.01701) }, { 0.0003146184245916576d, new GammaParticle(82629.0, 0.015) }, { 0.00040806009669537986d, new GammaParticle(83631.0, 0.01483) }, { 9.34416721037223e-05d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    