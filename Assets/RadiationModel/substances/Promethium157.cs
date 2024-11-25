using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium157";
        public override double halfLife { get; } = 10.56d;
        public override double atomicWeight { get; } = 156.93312d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium157() }, { 1.0d, new BetaParticle(-1, 2190500.0) }, { 0.012450000000000001d, new GammaParticle(52395.0, 0.02366) }, { 0.0022d, new GammaParticle(55837.0, 0.0222) }, { 0.010375d, new GammaParticle(73361.0, 0.0169) }, { 0.000675d, new GammaParticle(90770.0, 0.01366) }, { 0.019125d, new GammaParticle(108191.0, 0.01146) }, { 0.00315d, new GammaParticle(125730.0, 0.00986) }, { 0.013975d, new GammaParticle(132220.0, 0.00938) }, { 0.25d, new GammaParticle(160610.0, 0.00772) }, { 0.029249999999999998d, new GammaParticle(164036.0, 0.00756) }, { 0.09675d, new GammaParticle(188052.0, 0.00659) }, { 0.010549999999999999d, new GammaParticle(209790.0, 0.00591) }, { 0.005375d, new GammaParticle(222980.0, 0.00556) }, { 0.0176d, new GammaParticle(265619.0, 0.00467) }, { 0.018574999999999998d, new GammaParticle(296242.0, 0.00419) }, { 0.003975d, new GammaParticle(300470.0, 0.00413) }, { 0.016925d, new GammaParticle(348560.0, 0.00356) }, { 0.00505d, new GammaParticle(426060.0, 0.00291) }, { 0.01125d, new GammaParticle(495660.0, 0.0025) }, { 0.0225d, new GammaParticle(518860.0, 0.00239) }, { 0.011000000000000001d, new GammaParticle(568720.0, 0.00218) }, { 0.011000000000000001d, new GammaParticle(568720.0, 0.00218) }, { 0.0385d, new GammaParticle(571270.0, 0.00217) }, { 0.013500000000000002d, new GammaParticle(621550.0, 0.00199) }, { 0.0075d, new GammaParticle(641810.0, 0.00193) }, { 0.0034999999999999996d, new GammaParticle(727850.0, 0.0017) }, { 0.01525d, new GammaParticle(783800.0, 0.00158) }, { 0.01575d, new GammaParticle(800500.0, 0.00155) }, { 0.034d, new GammaParticle(850500.0, 0.00146) }, { 0.006999999999999999d, new GammaParticle(856720.0, 0.00145) }, { 0.00625d, new GammaParticle(906490.0, 0.00137) }, { 0.003d, new GammaParticle(1052300.0, 0.00118) }, { 0.0155d, new GammaParticle(1073240.0, 0.00116) }, { 0.009000000000000001d, new GammaParticle(1202220.0, 0.00103) }, { 0.008d, new GammaParticle(1241360.0, 0.001) }, { 0.0095d, new GammaParticle(1261430.0, 0.00098) }, { 0.0085d, new GammaParticle(1295450.0, 0.00096) }, { 0.0055000000000000005d, new GammaParticle(1317590.0, 0.00094) }, { 0.01425d, new GammaParticle(1369730.0, 0.00091) }, { 0.006750000000000001d, new GammaParticle(1421940.0, 0.00087) }, { 0.0034999999999999996d, new GammaParticle(1477800.0, 0.00084) }, { 0.0045000000000000005d, new GammaParticle(1533700.0, 0.00081) }, { 0.0025d, new GammaParticle(1622000.0, 0.00076) }, { 0.0034999999999999996d, new GammaParticle(1694800.0, 0.00073) }, { 0.048568137288129d, new GammaParticle(6354.0, 0.19513) }, { 0.04303589126610932d, new GammaParticle(39522.0, 0.03137) }, { 0.07789301586626121d, new GammaParticle(40117.0, 0.03091) }, { 0.024349198868544874d, new GammaParticle(45523.0, 0.02724) }, { 0.030631292176629455d, new GammaParticle(45998.0, 0.02695) }, { 0.006282093308084578d, new GammaParticle(46575.0, 0.02662) } } },

        };
    }
}
    