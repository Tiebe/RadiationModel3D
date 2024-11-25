using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium127n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127n";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 126.91937d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin127() }, { 1.0d, new BetaParticle(-1, 4180000.0) }, { 0.000221d, new GammaParticle(16520.0, 0.07505) }, { 0.03485d, new GammaParticle(104300.0, 0.01189) }, { 0.014025000000000001d, new GammaParticle(184810.0, 0.00671) }, { 0.01955d, new GammaParticle(219200.0, 0.00566) }, { 0.00935d, new GammaParticle(236000.0, 0.00525) }, { 0.02635d, new GammaParticle(257300.0, 0.00482) }, { 0.01955d, new GammaParticle(301140.0, 0.00412) }, { 0.029750000000000002d, new GammaParticle(359580.0, 0.00345) }, { 0.011049999999999999d, new GammaParticle(395600.0, 0.00313) }, { 0.0255d, new GammaParticle(405400.0, 0.00306) }, { 0.014450000000000001d, new GammaParticle(406900.0, 0.00305) }, { 0.009435d, new GammaParticle(464600.0, 0.00267) }, { 0.00425d, new GammaParticle(501900.0, 0.00247) }, { 0.08839999999999999d, new GammaParticle(567260.0, 0.00219) }, { 0.014450000000000001d, new GammaParticle(583200.0, 0.00213) }, { 0.0255d, new GammaParticle(646340.0, 0.00192) }, { 0.0076500000000000005d, new GammaParticle(650500.0, 0.00191) }, { 0.014450000000000001d, new GammaParticle(688000.0, 0.0018) }, { 0.391d, new GammaParticle(715520.0, 0.00173) }, { 0.0799d, new GammaParticle(732040.0, 0.00169) }, { 0.027200000000000002d, new GammaParticle(803200.0, 0.00154) }, { 0.0408d, new GammaParticle(821890.0, 0.00151) }, { 0.0527d, new GammaParticle(871400.0, 0.00142) }, { 0.08839999999999999d, new GammaParticle(952800.0, 0.0013) }, { 0.014450000000000001d, new GammaParticle(974700.0, 0.00127) }, { 0.0255d, new GammaParticle(979100.0, 0.00127) }, { 0.04845d, new GammaParticle(1071300.0, 0.00116) }, { 0.85d, new GammaParticle(1094700.0, 0.00113) }, { 0.00935d, new GammaParticle(1217400.0, 0.00102) }, { 0.1258d, new GammaParticle(1242710.0, 0.001) }, { 0.0204d, new GammaParticle(1293300.0, 0.00096) }, { 0.0085d, new GammaParticle(1373100.0, 0.0009) }, { 0.028900000000000002d, new GammaParticle(1439400.0, 0.00086) }, { 0.0391d, new GammaParticle(1461020.0, 0.00085) }, { 0.01955d, new GammaParticle(1521800.0, 0.00081) }, { 0.034d, new GammaParticle(1558500.0, 0.0008) }, { 0.013600000000000001d, new GammaParticle(1689000.0, 0.00073) }, { 0.2278d, new GammaParticle(1778300.0, 0.0007) }, { 0.029750000000000002d, new GammaParticle(1819700.0, 0.00068) }, { 0.014450000000000001d, new GammaParticle(2103600.0, 0.00059) }, { 0.09179999999999999d, new GammaParticle(2510300.0, 0.00049) }, { 0.00425d, new GammaParticle(2766300.0, 0.00045) }, { 0.0068000000000000005d, new GammaParticle(2804900.0, 0.00044) }, { 0.034d, new GammaParticle(3753.0, 0.33036) }, { 0.01d, new GammaParticle(25044.0, 0.04951) }, { 0.0187d, new GammaParticle(25271.0, 0.04906) }, { 0.0053d, new GammaParticle(28579.0, 0.04338) }, { 0.0063d, new GammaParticle(28810.0, 0.04304) }, { 0.00104d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    