using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver100 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver100";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 99.91612d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium100() }, { 1.0d, new BetaParticle(1, 3726500.0) }, { 0.0043472d, new GammaParticle(190500.0, 0.00651) }, { 0.00988d, new GammaParticle(222500.0, 0.00557) }, { 0.09287200000000001d, new GammaParticle(280700.0, 0.00442) }, { 0.007904d, new GammaParticle(348300.0, 0.00356) }, { 0.0096824d, new GammaParticle(353000.0, 0.00351) }, { 0.18080400000000002d, new GammaParticle(450200.0, 0.00275) }, { 0.021736d, new GammaParticle(528900.0, 0.00234) }, { 0.00741d, new GammaParticle(569500.0, 0.00218) }, { 0.027664d, new GammaParticle(609600.0, 0.00203) }, { 0.001976d, new GammaParticle(614000.0, 0.00202) }, { 0.08299200000000001d, new GammaParticle(639900.0, 0.00194) }, { 0.988d, new GammaParticle(665700.0, 0.00186) }, { 0.07607599999999999d, new GammaParticle(730900.0, 0.0017) }, { 0.8101600000000001d, new GammaParticle(750800.0, 0.00165) }, { 0.23119199999999998d, new GammaParticle(773300.0, 0.0016) }, { 0.036556000000000005d, new GammaParticle(862500.0, 0.00144) }, { 0.026676000000000002d, new GammaParticle(890400.0, 0.00139) }, { 0.012844d, new GammaParticle(922300.0, 0.00134) }, { 0.0010868d, new GammaParticle(953300.0, 0.0013) }, { 0.016796d, new GammaParticle(960700.0, 0.00129) }, { 0.134368d, new GammaParticle(1053900.0, 0.00118) }, { 0.03952d, new GammaParticle(1115800.0, 0.00111) }, { 0.051376d, new GammaParticle(1260500.0, 0.00098) }, { 0.03952d, new GammaParticle(1278000.0, 0.00097) }, { 0.033592d, new GammaParticle(1405300.0, 0.00088) }, { 0.130416d, new GammaParticle(1503800.0, 0.00082) }, { 0.008892d, new GammaParticle(1523200.0, 0.00081) }, { 0.008892d, new GammaParticle(1587900.0, 0.00078) }, { 0.003952d, new GammaParticle(1639000.0, 0.00076) }, { 0.07607599999999999d, new GammaParticle(1685800.0, 0.00074) }, { 0.007904d, new GammaParticle(1767700.0, 0.0007) }, { 0.00988d, new GammaParticle(1819800.0, 0.00068) }, { 0.008892d, new GammaParticle(1956000.0, 0.00063) }, { 0.003952d, new GammaParticle(2013300.0, 0.00062) }, { 0.028652d, new GammaParticle(2119000.0, 0.00059) }, { 0.015808d, new GammaParticle(2214300.0, 0.00056) }, { 1.4464d, new GammaParticle(511000.0, 0.00243) }, { 0.013600000000000001d, new GammaParticle(3053.0, 0.40611) }, { 0.054000000000000006d, new GammaParticle(21020.0, 0.05898) }, { 0.102d, new GammaParticle(21177.0, 0.05855) }, { 0.027999999999999997d, new GammaParticle(23904.0, 0.05187) }, { 0.0327d, new GammaParticle(24070.0, 0.05151) }, { 0.0047599999999999995d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    