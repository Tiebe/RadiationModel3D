using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium102m";
        public override double halfLife { get; } = 5.28d;
        public override double atomicWeight { get; } = 101.90926d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium102() }, { 1.0d, new BetaParticle(-1, 2293200.0) }, { 0.000201d, new GammaParticle(256800.0, 0.00483) }, { 0.008265d, new GammaParticle(416300.0, 0.00298) }, { 0.04698d, new GammaParticle(418400.0, 0.00296) }, { 0.008844d, new GammaParticle(468900.0, 0.00264) }, { 0.067d, new GammaParticle(475000.0, 0.00261) }, { 0.87d, new GammaParticle(475200.0, 0.00261) }, { 0.060899999999999996d, new GammaParticle(497200.0, 0.00249) }, { 0.007839d, new GammaParticle(627700.0, 0.00198) }, { 0.26709d, new GammaParticle(628100.0, 0.00197) }, { 0.16094999999999998d, new GammaParticle(630200.0, 0.00197) }, { 0.003886d, new GammaParticle(636600.0, 0.00195) }, { 0.02349d, new GammaParticle(691800.0, 0.00179) }, { 0.026099999999999998d, new GammaParticle(695600.0, 0.00178) }, { 0.06351d, new GammaParticle(696900.0, 0.00178) }, { 0.001273d, new GammaParticle(734100.0, 0.00169) }, { 0.00871d, new GammaParticle(865500.0, 0.00143) }, { 0.008352d, new GammaParticle(920200.0, 0.00135) }, { 0.12875999999999999d, new GammaParticle(1046400.0, 0.00118) }, { 0.013049999999999999d, new GammaParticle(1074700.0, 0.00115) }, { 0.0037519999999999997d, new GammaParticle(1102700.0, 0.00112) }, { 0.12615d, new GammaParticle(1103300.0, 0.00112) }, { 0.00737d, new GammaParticle(1105500.0, 0.00112) }, { 0.022968000000000002d, new GammaParticle(1113100.0, 0.00111) }, { 0.011918999999999999d, new GammaParticle(1127500.0, 0.0011) }, { 0.006264d, new GammaParticle(1179200.0, 0.00105) }, { 0.07656d, new GammaParticle(1197600.0, 0.00104) }, { 0.0435d, new GammaParticle(1292500.0, 0.00096) }, { 0.009309d, new GammaParticle(1318000.0, 0.00094) }, { 0.04176d, new GammaParticle(1338600.0, 0.00093) }, { 0.003618d, new GammaParticle(1361800.0, 0.00091) }, { 0.006873000000000001d, new GammaParticle(1488100.0, 0.00083) }, { 0.009396d, new GammaParticle(1511100.0, 0.00082) }, { 0.000603d, new GammaParticle(1581000.0, 0.00078) }, { 0.028275d, new GammaParticle(1596200.0, 0.00078) }, { 0.15747d, new GammaParticle(1615300.0, 0.00077) }, { 0.02871d, new GammaParticle(1711200.0, 0.00072) }, { 0.059160000000000004d, new GammaParticle(1810700.0, 0.00068) }, { 0.016704d, new GammaParticle(1907300.0, 0.00065) }, { 0.01566d, new GammaParticle(1945800.0, 0.00064) }, { 0.014790000000000001d, new GammaParticle(1967000.0, 0.00063) }, { 0.018183d, new GammaParticle(2139200.0, 0.00058) }, { 0.002345d, new GammaParticle(2201000.0, 0.00056) }, { 0.058289999999999995d, new GammaParticle(2225700.0, 0.00056) }, { 0.12093d, new GammaParticle(2244700.0, 0.00055) }, { 0.005568d, new GammaParticle(2340000.0, 0.00053) }, { 0.002278d, new GammaParticle(2434000.0, 0.00051) }, { 0.04698d, new GammaParticle(2438400.0, 0.00051) }, { 0.005046d, new GammaParticle(2536000.0, 0.00049) } } },

        };
    }
}
    