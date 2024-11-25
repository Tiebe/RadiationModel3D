using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium170";
        public override double halfLife { get; } = 165.6d;
        public override double atomicWeight { get; } = 169.93962d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium170() }, { 1.0d, new BetaParticle(-1, 1933750.0) }, { 0.026000000000000002d, new GammaParticle(51300.0, 0.02417) }, { 0.11630000000000001d, new GammaParticle(78650.0, 0.01576) }, { 0.010700000000000001d, new GammaParticle(87160.0, 0.01422) }, { 0.025d, new GammaParticle(94670.0, 0.0131) }, { 0.046d, new GammaParticle(103540.0, 0.01197) }, { 0.036000000000000004d, new GammaParticle(123900.0, 0.01001) }, { 0.017d, new GammaParticle(141500.0, 0.00876) }, { 0.038d, new GammaParticle(165360.0, 0.0075) }, { 0.24d, new GammaParticle(181570.0, 0.00683) }, { 0.012d, new GammaParticle(218690.0, 0.00567) }, { 0.036000000000000004d, new GammaParticle(227410.0, 0.00545) }, { 0.38d, new GammaParticle(258170.0, 0.0048) }, { 0.027000000000000003d, new GammaParticle(280440.0, 0.00442) }, { 0.027000000000000003d, new GammaParticle(283420.0, 0.00437) }, { 0.032d, new GammaParticle(413200.0, 0.003) }, { 0.034d, new GammaParticle(477400.0, 0.0026) }, { 0.0123d, new GammaParticle(662900.0, 0.00187) }, { 0.016d, new GammaParticle(746000.0, 0.00166) }, { 0.054000000000000006d, new GammaParticle(750400.0, 0.00165) }, { 0.049d, new GammaParticle(786300.0, 0.00158) }, { 0.006999999999999999d, new GammaParticle(832500.0, 0.00149) }, { 0.025d, new GammaParticle(843500.0, 0.00147) }, { 0.107d, new GammaParticle(854700.0, 0.00145) }, { 0.016d, new GammaParticle(854700.0, 0.00145) }, { 0.022000000000000002d, new GammaParticle(867000.0, 0.00143) }, { 0.0038d, new GammaParticle(872600.0, 0.00142) }, { 0.22d, new GammaParticle(890200.0, 0.00139) }, { 0.37d, new GammaParticle(932100.0, 0.00133) }, { 0.015d, new GammaParticle(934100.0, 0.00133) }, { 0.21d, new GammaParticle(941400.0, 0.00132) }, { 0.038d, new GammaParticle(957400.0, 0.0013) }, { 0.03d, new GammaParticle(976500.0, 0.00127) }, { 0.016d, new GammaParticle(1024700.0, 0.00121) }, { 0.065d, new GammaParticle(1044200.0, 0.00119) }, { 0.0045000000000000005d, new GammaParticle(1048700.0, 0.00118) }, { 0.021d, new GammaParticle(1111800.0, 0.00112) }, { 0.21d, new GammaParticle(1138700.0, 0.00109) }, { 0.02d, new GammaParticle(1153000.0, 0.00108) }, { 0.031d, new GammaParticle(1226000.0, 0.00101) }, { 0.0045000000000000005d, new GammaParticle(1306900.0, 0.00095) }, { 0.223d, new GammaParticle(7933.0, 0.15629) }, { 0.142d, new GammaParticle(48222.0, 0.02571) }, { 0.25d, new GammaParticle(49128.0, 0.02524) }, { 0.08199999999999999d, new GammaParticle(55779.0, 0.02223) }, { 0.10300000000000001d, new GammaParticle(56399.0, 0.02198) }, { 0.021d, new GammaParticle(57145.0, 0.0217) } } },

        };
    }
}
    