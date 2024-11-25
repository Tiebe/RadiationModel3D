using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium102";
        public override double halfLife { get; } = 17910720.0d;
        public override double atomicWeight { get; } = 101.90683d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium102() }, { 1.0d, new BetaParticle(1, -1105000.0) }, { 0.0001d, new GammaParticle(216900.0, 0.00572) }, { 0.0005d, new GammaParticle(224900.0, 0.00551) }, { 0.0002d, new GammaParticle(256800.0, 0.00483) }, { 0.0003d, new GammaParticle(415250.0, 0.00299) }, { 0.0012d, new GammaParticle(418520.0, 0.00296) }, { 0.0008d, new GammaParticle(456420.0, 0.00272) }, { 0.028999999999999998d, new GammaParticle(468580.0, 0.00265) }, { 0.46d, new GammaParticle(475060.0, 0.00261) }, { 0.045d, new GammaParticle(628050.0, 0.00197) }, { 0.001d, new GammaParticle(631290.0, 0.00196) }, { 0.0023d, new GammaParticle(636810.0, 0.00195) }, { 0.0058d, new GammaParticle(680660.0, 0.00182) }, { 0.001d, new GammaParticle(733930.0, 0.00169) }, { 0.0053d, new GammaParticle(739580.0, 0.00168) }, { 0.0003d, new GammaParticle(930500.0, 0.00133) }, { 0.0002d, new GammaParticle(933200.0, 0.00133) }, { 0.0043d, new GammaParticle(1046590.0, 0.00118) }, { 0.028999999999999998d, new GammaParticle(1103160.0, 0.00112) }, { 0.0039000000000000003d, new GammaParticle(1105700.0, 0.00112) }, { 0.0058d, new GammaParticle(1158100.0, 0.00107) }, { 0.0039000000000000003d, new GammaParticle(1362100.0, 0.00091) }, { 0.0011d, new GammaParticle(1562200.0, 0.00079) }, { 0.0001d, new GammaParticle(1568700.0, 0.00079) }, { 0.0005d, new GammaParticle(1580500.0, 0.00078) }, { 0.0001d, new GammaParticle(1786400.0, 0.00069) }, { 0.0003d, new GammaParticle(2037000.0, 0.00061) }, { 1e-05d, new GammaParticle(2044100.0, 0.00061) }, { 0.0002d, new GammaParticle(2261300.0, 0.00055) }, { 0.29436d, new GammaParticle(511000.0, 0.00243) }, { 0.027000000000000003d, new GammaParticle(2737.0, 0.45299) }, { 0.121d, new GammaParticle(19150.0, 0.06474) }, { 0.22899999999999998d, new GammaParticle(19279.0, 0.06431) }, { 0.061500000000000006d, new GammaParticle(21736.0, 0.05704) }, { 0.07139999999999999d, new GammaParticle(21875.0, 0.05668) }, { 0.01d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.22d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium102() }, { 1.0d, new BetaParticle(-1, 560000.0) }, { 0.02d, new GammaParticle(556600.0, 0.00223) } } },

        };
    }
}
    