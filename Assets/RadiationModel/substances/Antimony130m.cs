using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony130m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony130m";
        public override double halfLife { get; } = 378.0d;
        public override double atomicWeight { get; } = 129.91167d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium130() }, { 1.0d, new BetaParticle(-1, 2535980.0) }, { 0.41d, new GammaParticle(182330.0, 0.0068) }, { 0.051d, new GammaParticle(348500.0, 0.00356) }, { 0.02d, new GammaParticle(370000.0, 0.00335) }, { 0.005d, new GammaParticle(405200.0, 0.00306) }, { 0.031d, new GammaParticle(468000.0, 0.00265) }, { 0.019d, new GammaParticle(481600.0, 0.00257) }, { 0.019d, new GammaParticle(502600.0, 0.00247) }, { 0.051d, new GammaParticle(627100.0, 0.00198) }, { 0.048d, new GammaParticle(647700.0, 0.00191) }, { 0.006999999999999999d, new GammaParticle(658000.0, 0.00188) }, { 0.044000000000000004d, new GammaParticle(697400.0, 0.00178) }, { 0.04d, new GammaParticle(748600.0, 0.00166) }, { 0.86d, new GammaParticle(793400.0, 0.00156) }, { 0.12d, new GammaParticle(816300.0, 0.00152) }, { 1.0d, new GammaParticle(839520.0, 0.00148) }, { 0.004d, new GammaParticle(861600.0, 0.00144) }, { 0.04d, new GammaParticle(920800.0, 0.00135) }, { 0.027999999999999997d, new GammaParticle(942200.0, 0.00132) }, { 0.01d, new GammaParticle(949800.0, 0.00131) }, { 0.016d, new GammaParticle(985400.0, 0.00126) }, { 0.3d, new GammaParticle(1017500.0, 0.00122) }, { 0.01d, new GammaParticle(1039600.0, 0.00119) }, { 0.027999999999999997d, new GammaParticle(1046500.0, 0.00118) }, { 0.022000000000000002d, new GammaParticle(1071700.0, 0.00116) }, { 0.037000000000000005d, new GammaParticle(1102800.0, 0.00112) }, { 0.013000000000000001d, new GammaParticle(1131900.0, 0.0011) }, { 0.055999999999999994d, new GammaParticle(1142000.0, 0.00109) }, { 0.022000000000000002d, new GammaParticle(1177300.0, 0.00105) }, { 0.036000000000000004d, new GammaParticle(1200000.0, 0.00103) }, { 0.013000000000000001d, new GammaParticle(1232300.0, 0.00101) }, { 0.008d, new GammaParticle(1298900.0, 0.00095) }, { 0.004d, new GammaParticle(1323100.0, 0.00094) }, { 0.013000000000000001d, new GammaParticle(1491200.0, 0.00083) }, { 0.026000000000000002d, new GammaParticle(1598000.0, 0.00078) }, { 0.013000000000000001d, new GammaParticle(1896900.0, 0.00065) }, { 0.004d, new GammaParticle(1925700.0, 0.00064) }, { 0.004d, new GammaParticle(1934100.0, 0.00064) }, { 0.01d, new GammaParticle(2116600.0, 0.00059) }, { 0.005d, new GammaParticle(2136500.0, 0.00058) }, { 0.003d, new GammaParticle(2999100.0, 0.00041) }, { 0.0070186446034226d, new GammaParticle(4135.0, 0.29984) }, { 0.01816916377388884d, new GammaParticle(27202.0, 0.04558) }, { 0.033834569411338625d, new GammaParticle(27473.0, 0.04513) }, { 0.009682864371218196d, new GammaParticle(31093.0, 0.03988) }, { 0.011784045939772544d, new GammaParticle(31359.0, 0.03954) }, { 0.0021011815685543487d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    