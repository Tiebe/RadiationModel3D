using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold204 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold204";
        public override double halfLife { get; } = 39.8d;
        public override double atomicWeight { get; } = 203.97811d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury204() }, { 1.0d, new BetaParticle(-1, 2150050.0) }, { 0.91d, new GammaParticle(436551.0, 0.00284) }, { 0.0273d, new GammaParticle(554700.0, 0.00224) }, { 0.0819d, new GammaParticle(654900.0, 0.00189) }, { 0.24024d, new GammaParticle(691740.0, 0.00179) }, { 0.22204000000000002d, new GammaParticle(723000.0, 0.00171) }, { 0.0027300000000000002d, new GammaParticle(897900.0, 0.00138) }, { 0.01638d, new GammaParticle(1172000.0, 0.00106) }, { 0.22021999999999997d, new GammaParticle(1392150.0, 0.00089) }, { 0.038584d, new GammaParticle(1404820.0, 0.00088) }, { 0.08736000000000001d, new GammaParticle(1414720.0, 0.00088) }, { 0.25207d, new GammaParticle(1511100.0, 0.00082) }, { 0.059241d, new GammaParticle(1552800.0, 0.0008) }, { 0.003367d, new GammaParticle(1598400.0, 0.00078) }, { 0.002002d, new GammaParticle(1680400.0, 0.00074) }, { 0.031122d, new GammaParticle(1704300.0, 0.00073) }, { 0.001456d, new GammaParticle(1817400.0, 0.00068) }, { 0.020293000000000002d, new GammaParticle(1827800.0, 0.00068) }, { 0.026480999999999998d, new GammaParticle(1841380.0, 0.00067) }, { 0.0025480000000000004d, new GammaParticle(1851700.0, 0.00067) }, { 0.003549d, new GammaParticle(1863300.0, 0.00067) }, { 0.013376999999999998d, new GammaParticle(1947760.0, 0.00064) }, { 0.0026390000000000003d, new GammaParticle(1959000.0, 0.00063) }, { 0.003458d, new GammaParticle(2028900.0, 0.00061) }, { 0.010465d, new GammaParticle(2088500.0, 0.00059) }, { 0.006552d, new GammaParticle(2376260.0, 0.00052) }, { 0.001001d, new GammaParticle(2385900.0, 0.00052) }, { 0.012688348517956477d, new GammaParticle(11777.0, 0.10528) }, { 0.009039530163878323d, new GammaParticle(68894.0, 0.018) }, { 0.015323834826035467d, new GammaParticle(70820.0, 0.01751) }, { 0.0052005326660604844d, new GammaParticle(80316.0, 0.01544) }, { 0.006724288737216207d, new GammaParticle(81285.0, 0.01525) }, { 0.001523756071155722d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    