using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium233";
        public override double halfLife { get; } = 2330640.0d;
        public override double atomicWeight { get; } = 233.04025d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium233() }, { 1.0d, new BetaParticle(-1, 285150.00001) }, { 9.545e-05d, new GammaParticle(17260.0, 0.07183) }, { 0.0007330559999999999d, new GammaParticle(28562.0, 0.04341) }, { 0.00022793460000000002d, new GammaParticle(40351.0, 0.03073) }, { 0.0001321028d, new GammaParticle(41660.0, 0.02976) }, { 9.9268e-06d, new GammaParticle(51500.0, 0.02407) }, { 9.1632e-06d, new GammaParticle(57900.0, 0.02141) }, { 0.01286666d, new GammaParticle(75274.0, 0.01647) }, { 0.020082680000000002d, new GammaParticle(86591.0, 0.01432) }, { 1.98536e-05d, new GammaParticle(92100.0, 0.01346) }, { 0.008498868d, new GammaParticle(103860.0, 0.01194) }, { 4.16162e-05d, new GammaParticle(228570.0, 0.00542) }, { 0.000603244d, new GammaParticle(248370.0, 0.00499) }, { 0.000278714d, new GammaParticle(258450.0, 0.0048) }, { 0.00320712d, new GammaParticle(271556.0, 0.00457) }, { 0.00013363d, new GammaParticle(280580.0, 0.00442) }, { 0.0001909d, new GammaParticle(288330.0, 0.0043) }, { 0.0012217600000000001d, new GammaParticle(298810.0, 0.00415) }, { 0.06544052d, new GammaParticle(300128.0, 0.00413) }, { 0.000137448d, new GammaParticle(301930.0, 0.00411) }, { 0.3818d, new GammaParticle(311901.0, 0.00398) }, { 5.03976e-05d, new GammaParticle(320730.0, 0.00387) }, { 0.04440334d, new GammaParticle(340477.0, 0.00364) }, { 0.006799858d, new GammaParticle(375407.0, 0.0033) }, { 3.66528e-05d, new GammaParticle(380280.0, 0.00326) }, { 0.0135539d, new GammaParticle(398494.0, 0.00311) }, { 0.0173719d, new GammaParticle(415767.0, 0.00298) }, { 1.06904e-05d, new GammaParticle(455960.0, 0.00272) }, { 0.413d, new GammaParticle(16678.0, 0.07434) }, { 0.09056989875265527d, new GammaParticle(94657.0, 0.0131) }, { 0.14498142909021175d, new GammaParticle(98439.0, 0.0126) }, { 0.05230573449863961d, new GammaParticle(111238.0, 0.01115) }, { 0.07019429569717436d, new GammaParticle(112645.0, 0.01101) }, { 0.01788856119853475d, new GammaParticle(114446.0, 0.01083) } } },

        };
    }
}
    