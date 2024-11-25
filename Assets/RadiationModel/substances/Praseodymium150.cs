using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium150";
        public override double halfLife { get; } = 6.19d;
        public override double atomicWeight { get; } = 149.92668d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neodymium150() }, { 1.0d, new BetaParticle(-1, 2689500.0) }, { 0.326d, new GammaParticle(130230.0, 0.00952) }, { 0.0006519999999999999d, new GammaParticle(174300.0, 0.00711) }, { 0.0010758d, new GammaParticle(234410.0, 0.00529) }, { 0.03097d, new GammaParticle(251240.0, 0.00493) }, { 0.018582d, new GammaParticle(329370.0, 0.00376) }, { 0.008801999999999999d, new GammaParticle(349020.0, 0.00355) }, { 0.00978d, new GammaParticle(373440.0, 0.00332) }, { 0.012388d, new GammaParticle(431000.0, 0.00288) }, { 0.006194d, new GammaParticle(432790.0, 0.00286) }, { 0.0108232d, new GammaParticle(469190.0, 0.00264) }, { 0.023472d, new GammaParticle(545060.0, 0.00227) }, { 0.013040000000000001d, new GammaParticle(553480.0, 0.00224) }, { 0.0026079999999999996d, new GammaParticle(634100.0, 0.00196) }, { 0.0015974d, new GammaParticle(680500.0, 0.00182) }, { 0.04661800000000001d, new GammaParticle(720530.0, 0.00172) }, { 0.07106799999999999d, new GammaParticle(722750.0, 0.00172) }, { 0.033578000000000004d, new GammaParticle(804670.0, 0.00154) }, { 0.0013691999999999999d, new GammaParticle(819100.0, 0.00151) }, { 0.0045639999999999995d, new GammaParticle(850500.0, 0.00146) }, { 0.06194d, new GammaParticle(852910.0, 0.00145) }, { 0.0015974d, new GammaParticle(912500.0, 0.00136) }, { 0.027384d, new GammaParticle(931780.0, 0.00133) }, { 0.013366d, new GammaParticle(947300.0, 0.00131) }, { 0.017603999999999998d, new GammaParticle(1007160.0, 0.00123) }, { 0.027384d, new GammaParticle(1061960.0, 0.00117) }, { 0.006520000000000001d, new GammaParticle(1070300.0, 0.00116) }, { 0.023472d, new GammaParticle(1074520.0, 0.00115) }, { 0.05379d, new GammaParticle(1141260.0, 0.00109) }, { 0.005868d, new GammaParticle(1156100.0, 0.00107) }, { 0.014018d, new GammaParticle(1158560.0, 0.00107) }, { 0.020863999999999997d, new GammaParticle(1216270.0, 0.00102) }, { 0.010431999999999999d, new GammaParticle(1218480.0, 0.00102) }, { 0.006194d, new GammaParticle(1414970.0, 0.00088) }, { 0.0032600000000000003d, new GammaParticle(1584100.0, 0.00078) }, { 0.0022819999999999997d, new GammaParticle(1608100.0, 0.00077) }, { 0.001956d, new GammaParticle(1781300.0, 0.0007) }, { 0.0022819999999999997d, new GammaParticle(1837300.0, 0.00067) }, { 0.0022819999999999997d, new GammaParticle(1878900.0, 0.00066) }, { 0.005542d, new GammaParticle(1939000.0, 0.00064) }, { 0.0016300000000000002d, new GammaParticle(2366000.0, 0.00052) }, { 0.000978d, new GammaParticle(2409000.0, 0.00051) }, { 0.000978d, new GammaParticle(2707000.0, 0.00046) }, { 0.03308842625809952d, new GammaParticle(5870.0, 0.21122) }, { 0.047570438816679245d, new GammaParticle(36848.0, 0.03365) }, { 0.08663347080072709d, new GammaParticle(37362.0, 0.03318) }, { 0.02660589839034022d, new GammaParticle(42380.0, 0.02926) }, { 0.03344361427665766d, new GammaParticle(42810.0, 0.02896) }, { 0.006837715886317437d, new GammaParticle(43335.0, 0.02861) } } },

        };
    }
}
    