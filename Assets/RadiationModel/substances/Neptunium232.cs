using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium232";
        public override double halfLife { get; } = 882.0d;
        public override double atomicWeight { get; } = 232.04011d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium232() }, { 1.0d, new BetaParticle(1, 706500.0) }, { 0.00424d, new GammaParticle(143400.0, 0.00865) }, { 0.00318d, new GammaParticle(165000.0, 0.00751) }, { 0.022789999999999998d, new GammaParticle(223600.0, 0.00554) }, { 0.2014d, new GammaParticle(282000.0, 0.0044) }, { 0.53d, new GammaParticle(327300.0, 0.00379) }, { 0.01272d, new GammaParticle(377000.0, 0.00329) }, { 0.005829999999999999d, new GammaParticle(710700.0, 0.00174) }, { 0.04293d, new GammaParticle(755000.0, 0.00164) }, { 0.041870000000000004d, new GammaParticle(814800.0, 0.00152) }, { 0.3392d, new GammaParticle(819500.0, 0.00151) }, { 0.20670000000000002d, new GammaParticle(864300.0, 0.00143) }, { 0.2491d, new GammaParticle(867200.0, 0.00143) }, { 0.00848d, new GammaParticle(895100.0, 0.00139) }, { 0.00954d, new GammaParticle(924400.0, 0.00134) }, { 0.01643d, new GammaParticle(941600.0, 0.00132) }, { 0.00318d, new GammaParticle(970900.0, 0.00128) }, { 0.005829999999999999d, new GammaParticle(1016800.0, 0.00122) }, { 0.03339d, new GammaParticle(1037400.0, 0.0012) }, { 0.010069999999999999d, new GammaParticle(1085400.0, 0.00114) }, { 0.014839999999999999d, new GammaParticle(1126000.0, 0.0011) }, { 0.00901d, new GammaParticle(1133100.0, 0.00109) }, { 0.0037099999999999998d, new GammaParticle(1146300.0, 0.00108) }, { 0.0037099999999999998d, new GammaParticle(1146300.0, 0.00108) }, { 0.0037099999999999998d, new GammaParticle(1193900.0, 0.00104) }, { 0.00424d, new GammaParticle(1936000.0, 0.00064) }, { 0.0011020000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.456d, new GammaParticle(16678.0, 0.07434) }, { 0.243d, new GammaParticle(94657.0, 0.0131) }, { 0.389d, new GammaParticle(98439.0, 0.0126) }, { 0.14d, new GammaParticle(111238.0, 0.01115) }, { 0.188d, new GammaParticle(112645.0, 0.01101) }, { 0.048d, new GammaParticle(114446.0, 0.01083) } } },
            { 2e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium228() }, { 1.0d, new AlphaParticle(7033002.09) } } },

        };
    }
}
    