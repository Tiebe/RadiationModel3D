using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine131 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine131";
        public override double halfLife { get; } = 693377.28d;
        public override double atomicWeight { get; } = 130.90613d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon131() }, { 1.0d, new BetaParticle(-1, 485437.5) }, { 0.0261615d, new GammaParticle(80185.0, 0.01546) }, { 8.965e-07d, new GammaParticle(85900.0, 0.01443) }, { 0.000211085d, new GammaParticle(163930.0, 0.00756) }, { 0.0026895d, new GammaParticle(177214.0, 0.007) }, { 3.1785e-05d, new GammaParticle(232180.0, 0.00534) }, { 0.000576205d, new GammaParticle(272498.0, 0.00455) }, { 0.061206500000000004d, new GammaParticle(284305.0, 0.00436) }, { 1.793e-05d, new GammaParticle(295800.0, 0.00419) }, { 4.727e-05d, new GammaParticle(302400.0, 0.0041) }, { 0.00077425d, new GammaParticle(318088.0, 0.0039) }, { 0.0002119d, new GammaParticle(324651.0, 0.00382) }, { 0.00273025d, new GammaParticle(325789.0, 0.00381) }, { 0.00016299999999999998d, new GammaParticle(358400.0, 0.00346) }, { 0.815d, new GammaParticle(364489.0, 0.0034) }, { 0.00054605d, new GammaParticle(404814.0, 0.00306) }, { 7.335000000000001e-05d, new GammaParticle(449600.0, 0.00276) }, { 0.00359415d, new GammaParticle(503004.0, 0.00246) }, { 0.07155700000000001d, new GammaParticle(636989.0, 0.00195) }, { 0.0021679d, new GammaParticle(642719.0, 0.00193) }, { 0.0176855d, new GammaParticle(722911.0, 0.00172) }, { 0.006040157907418778d, new GammaParticle(4540.0, 0.27309) }, { 0.01446036761837186d, new GammaParticle(29458.0, 0.04209) }, { 0.02678838017482746d, new GammaParticle(29778.0, 0.04164) }, { 0.007765844345855567d, new GammaParticle(33726.0, 0.03676) }, { 0.00959858361147748d, new GammaParticle(34030.0, 0.03643) }, { 0.001832739265621914d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    