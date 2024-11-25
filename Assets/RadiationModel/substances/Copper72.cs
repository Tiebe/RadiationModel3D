using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper72 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper72";
        public override double halfLife { get; } = 6.63d;
        public override double atomicWeight { get; } = 71.93582d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zinc72() }, { 1.0d, new BetaParticle(-1, 4181250.0) }, { 0.005056000000000001d, new GammaParticle(535300.0, 0.00232) }, { 0.0025280000000000003d, new GammaParticle(599600.0, 0.00207) }, { 0.011850000000000001d, new GammaParticle(612300.0, 0.00202) }, { 0.79d, new GammaParticle(652680.0, 0.0019) }, { 0.0057669999999999996d, new GammaParticle(716180.0, 0.00173) }, { 0.003397d, new GammaParticle(753100.0, 0.00165) }, { 0.01422d, new GammaParticle(798700.0, 0.00155) }, { 0.09006d, new GammaParticle(846750.0, 0.00146) }, { 0.0158d, new GammaParticle(858300.0, 0.00144) }, { 0.001817d, new GammaParticle(928600.0, 0.00134) }, { 0.002765d, new GammaParticle(942400.0, 0.00132) }, { 0.002686d, new GammaParticle(959900.0, 0.00129) }, { 0.015009999999999999d, new GammaParticle(988240.0, 0.00125) }, { 0.13666999999999999d, new GammaParticle(1004700.0, 0.00123) }, { 0.03871d, new GammaParticle(1016000.0, 0.00122) }, { 0.009479999999999999d, new GammaParticle(1146400.0, 0.00108) }, { 0.060039999999999996d, new GammaParticle(1251500.0, 0.00099) }, { 0.0030020000000000003d, new GammaParticle(1404300.0, 0.00088) }, { 0.0058460000000000005d, new GammaParticle(1408300.0, 0.00088) }, { 0.005608999999999999d, new GammaParticle(1469000.0, 0.00084) }, { 0.00869d, new GammaParticle(1516000.0, 0.00082) }, { 0.05372d, new GammaParticle(1540000.0, 0.00081) }, { 0.0024490000000000002d, new GammaParticle(1610500.0, 0.00077) }, { 0.09243d, new GammaParticle(1657600.0, 0.00075) }, { 0.004661d, new GammaParticle(1789300.0, 0.00069) }, { 0.00632d, new GammaParticle(1896000.0, 0.00065) }, { 0.01106d, new GammaParticle(1917300.0, 0.00065) }, { 0.0553d, new GammaParticle(1993100.0, 0.00062) }, { 0.0316d, new GammaParticle(2004400.0, 0.00062) }, { 0.01027d, new GammaParticle(2040500.0, 0.00061) }, { 0.004345d, new GammaParticle(2050300.0, 0.0006) }, { 0.009479999999999999d, new GammaParticle(2094900.0, 0.00059) }, { 0.011850000000000001d, new GammaParticle(2169000.0, 0.00057) }, { 0.01264d, new GammaParticle(2206700.0, 0.00056) }, { 0.018959999999999998d, new GammaParticle(2236500.0, 0.00055) }, { 0.04424d, new GammaParticle(2255600.0, 0.00055) }, { 0.04424d, new GammaParticle(2409200.0, 0.00051) }, { 0.009479999999999999d, new GammaParticle(2517500.0, 0.00049) }, { 0.00869d, new GammaParticle(2540000.0, 0.00049) }, { 0.01343d, new GammaParticle(2594000.0, 0.00048) }, { 0.00869d, new GammaParticle(2769800.0, 0.00045) }, { 0.02291d, new GammaParticle(2859200.0, 0.00043) }, { 0.01264d, new GammaParticle(2921900.0, 0.00042) }, { 0.02844d, new GammaParticle(3008900.0, 0.00041) }, { 0.01817d, new GammaParticle(3054700.0, 0.00041) }, { 0.026070000000000003d, new GammaParticle(3100000.0, 0.0004) }, { 0.011850000000000001d, new GammaParticle(3212900.0, 0.00039) }, { 0.00553d, new GammaParticle(3246300.0, 0.00038) }, { 0.024489999999999998d, new GammaParticle(3348400.0, 0.00037) }, { 0.02291d, new GammaParticle(3477400.0, 0.00036) }, { 0.01738d, new GammaParticle(3706900.0, 0.00033) }, { 0.07821d, new GammaParticle(3865000.0, 0.00032) }, { 0.01106d, new GammaParticle(3941600.0, 0.00031) } } },

        };
    }
}
    