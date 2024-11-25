using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium79m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium79m";
        public override double halfLife { get; } = 39.0d;
        public override double atomicWeight { get; } = 78.92556d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic79() }, { 1.0d, new BetaParticle(-1, 2148000.0) }, { 0.11599999999999999d, new GammaParticle(109580.0, 0.01131) }, { 0.11699999999999999d, new GammaParticle(216400.0, 0.00573) }, { 0.61d, new GammaParticle(230442.0, 0.00538) }, { 0.011000000000000001d, new GammaParticle(287800.0, 0.00431) }, { 0.0086d, new GammaParticle(306980.0, 0.00404) }, { 0.0209d, new GammaParticle(325500.0, 0.00381) }, { 0.055999999999999994d, new GammaParticle(446900.0, 0.00277) }, { 0.063d, new GammaParticle(484860.0, 0.00256) }, { 0.044000000000000004d, new GammaParticle(524450.0, 0.00236) }, { 0.33d, new GammaParticle(542270.0, 0.00229) }, { 0.0106d, new GammaParticle(551210.0, 0.00225) }, { 0.133d, new GammaParticle(634000.0, 0.00196) }, { 0.031d, new GammaParticle(644610.0, 0.00192) }, { 0.04d, new GammaParticle(724130.0, 0.00171) }, { 0.078d, new GammaParticle(745030.0, 0.00166) }, { 0.036000000000000004d, new GammaParticle(749100.0, 0.00166) }, { 0.18d, new GammaParticle(755000.0, 0.00164) }, { 0.047d, new GammaParticle(765460.0, 0.00162) }, { 0.0246d, new GammaParticle(774740.0, 0.0016) }, { 0.12300000000000001d, new GammaParticle(781510.0, 0.00159) }, { 0.031d, new GammaParticle(825030.0, 0.0015) }, { 0.031d, new GammaParticle(875190.0, 0.00142) }, { 0.037000000000000005d, new GammaParticle(902320.0, 0.00137) }, { 0.098d, new GammaParticle(1015140.0, 0.00122) }, { 0.0215d, new GammaParticle(1031590.0, 0.0012) }, { 0.099d, new GammaParticle(1117560.0, 0.00111) }, { 0.047d, new GammaParticle(1192090.0, 0.00104) }, { 0.099d, new GammaParticle(1256320.0, 0.00099) }, { 0.028300000000000002d, new GammaParticle(1259650.0, 0.00098) }, { 0.047d, new GammaParticle(1418020.0, 0.00087) }, { 0.0209d, new GammaParticle(1538440.0, 0.00081) }, { 0.0258d, new GammaParticle(1557260.0, 0.0008) }, { 0.027999999999999997d, new GammaParticle(1571330.0, 0.00079) }, { 0.0184d, new GammaParticle(1845370.0, 0.00067) }, { 0.022099999999999998d, new GammaParticle(2594200.0, 0.00048) }, { 0.000553579462d, new GammaParticle(1320.0, 0.93927) }, { 0.004476679018315447d, new GammaParticle(10509.0, 0.11798) }, { 0.008687519926868711d, new GammaParticle(10544.0, 0.11759) }, { 0.001986426628267334d, new GammaParticle(11773.0, 0.10531) }, { 0.0020615135548158396d, new GammaParticle(11791.0, 0.10515) }, { 7.508692654850523e-05d, new GammaParticle(11861.0, 0.10453) } } },
            { 0.04d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium79() }, { 0.027999999999999997d, new GammaParticle(186020.0, 0.00667) }, { 0.000199687152d, new GammaParticle(1221.0, 1.01543) }, { 0.0016344083814793958d, new GammaParticle(9856.0, 0.1258) }, { 0.0031742248620691316d, new GammaParticle(9887.0, 0.1254) }, { 0.000710002697114944d, new GammaParticle(11026.0, 0.11245) }, { 0.0007256227564514727d, new GammaParticle(11038.0, 0.11232) }, { 1.562005933652877e-05d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    