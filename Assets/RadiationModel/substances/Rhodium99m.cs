using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium99m";
        public override double halfLife { get; } = 16920.0d;
        public override double atomicWeight { get; } = 98.90819d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9984000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium99() }, { 1.0d, new BetaParticle(1, 903450.0) }, { 0.0175d, new GammaParticle(89600.0, 0.01384) }, { 0.00017500000000000003d, new GammaParticle(101600.0, 0.0122) }, { 0.00091d, new GammaParticle(231600.0, 0.00535) }, { 0.0052d, new GammaParticle(250900.0, 0.00494) }, { 0.00017999999999999998d, new GammaParticle(271000.0, 0.00458) }, { 0.0167d, new GammaParticle(276600.0, 0.00448) }, { 0.009000000000000001d, new GammaParticle(322100.0, 0.00385) }, { 0.72d, new GammaParticle(340800.0, 0.00364) }, { 0.00033d, new GammaParticle(379170.0, 0.00327) }, { 0.00043d, new GammaParticle(411700.0, 0.00301) }, { 0.0066d, new GammaParticle(486100.0, 0.00255) }, { 0.0143d, new GammaParticle(528200.0, 0.00235) }, { 0.013300000000000001d, new GammaParticle(542800.0, 0.00228) }, { 0.002d, new GammaParticle(558200.0, 0.00222) }, { 0.0039000000000000003d, new GammaParticle(575700.0, 0.00215) }, { 0.00065d, new GammaParticle(600000.0, 0.00207) }, { 0.12300000000000001d, new GammaParticle(617800.0, 0.00201) }, { 0.0011d, new GammaParticle(644000.0, 0.00193) }, { 0.0055000000000000005d, new GammaParticle(659000.0, 0.00188) }, { 0.0086d, new GammaParticle(685600.0, 0.00181) }, { 0.0017000000000000001d, new GammaParticle(702000.0, 0.00177) }, { 0.0017000000000000001d, new GammaParticle(702000.0, 0.00177) }, { 0.0008d, new GammaParticle(707600.0, 0.00175) }, { 0.0125d, new GammaParticle(719300.0, 0.00172) }, { 0.0045000000000000005d, new GammaParticle(734100.0, 0.00169) }, { 0.002d, new GammaParticle(779100.0, 0.00159) }, { 0.00068d, new GammaParticle(808000.0, 0.00153) }, { 0.0055000000000000005d, new GammaParticle(850600.0, 0.00146) }, { 0.0018d, new GammaParticle(899900.0, 0.00138) }, { 0.0077d, new GammaParticle(920000.0, 0.00135) }, { 0.0225d, new GammaParticle(936600.0, 0.00132) }, { 0.0015d, new GammaParticle(965700.0, 0.00128) }, { 0.0018d, new GammaParticle(984800.0, 0.00126) }, { 0.00091d, new GammaParticle(1002000.0, 0.00124) }, { 0.002d, new GammaParticle(1119100.0, 0.00111) }, { 0.0022d, new GammaParticle(1158100.0, 0.00107) }, { 0.001d, new GammaParticle(1172200.0, 0.00106) }, { 0.0009d, new GammaParticle(1243400.0, 0.001) }, { 0.114d, new GammaParticle(1261200.0, 0.00098) }, { 0.0011d, new GammaParticle(1277700.0, 0.00097) }, { 0.00091d, new GammaParticle(1306200.0, 0.00095) }, { 0.0011d, new GammaParticle(1386800.0, 0.00089) }, { 0.0008d, new GammaParticle(1499500.0, 0.00083) }, { 0.112628d, new GammaParticle(511000.0, 0.00243) }, { 0.0432d, new GammaParticle(2737.0, 0.45299) }, { 0.193d, new GammaParticle(19150.0, 0.06474) }, { 0.366d, new GammaParticle(19279.0, 0.06431) }, { 0.098d, new GammaParticle(21736.0, 0.05704) }, { 0.114d, new GammaParticle(21875.0, 0.05668) }, { 0.0159d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.0016d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium99() } } },

        };
    }
}
    