using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium70 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium70";
        public override double halfLife { get; } = 2466.0d;
        public override double atomicWeight { get; } = 69.93352d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium70() }, { 1.0d, new BetaParticle(1, 4316050.0) }, { 0.019206d, new GammaParticle(32050.0, 0.03868) }, { 0.0040739999999999995d, new GammaParticle(39590.0, 0.03132) }, { 0.35792999999999997d, new GammaParticle(49510.0, 0.02504) }, { 0.007857d, new GammaParticle(86250.0, 0.01437) }, { 0.015714d, new GammaParticle(113530.0, 0.01092) }, { 0.00291d, new GammaParticle(129490.0, 0.00957) }, { 0.035211d, new GammaParticle(132540.0, 0.00935) }, { 0.02619d, new GammaParticle(135630.0, 0.00914) }, { 0.004365d, new GammaParticle(153200.0, 0.00809) }, { 0.007857d, new GammaParticle(160790.0, 0.00771) }, { 0.0017460000000000002d, new GammaParticle(198700.0, 0.00624) }, { 0.048888d, new GammaParticle(202730.0, 0.00612) }, { 0.006402d, new GammaParticle(223410.0, 0.00555) }, { 0.028517999999999998d, new GammaParticle(244140.0, 0.00508) }, { 0.004365d, new GammaParticle(247500.0, 0.00501) }, { 0.018333d, new GammaParticle(255860.0, 0.00485) }, { 0.027645d, new GammaParticle(263200.0, 0.00471) }, { 0.004365d, new GammaParticle(290200.0, 0.00427) }, { 0.028227000000000002d, new GammaParticle(293590.0, 0.00422) }, { 0.004365d, new GammaParticle(297100.0, 0.00417) }, { 0.0034920000000000003d, new GammaParticle(301800.0, 0.00411) }, { 0.002328d, new GammaParticle(312640.0, 0.00397) }, { 0.006693d, new GammaParticle(343850.0, 0.00361) }, { 0.09428399999999999d, new GammaParticle(376650.0, 0.00329) }, { 0.020952000000000002d, new GammaParticle(413910.0, 0.003) }, { 0.29100000000000004d, new GammaParticle(426150.0, 0.00291) }, { 0.0026190000000000002d, new GammaParticle(458420.0, 0.0027) }, { 0.012804d, new GammaParticle(499690.0, 0.00248) }, { 0.003201d, new GammaParticle(545910.0, 0.00227) }, { 0.00291d, new GammaParticle(549690.0, 0.00226) }, { 0.0017460000000000002d, new GammaParticle(561560.0, 0.00221) }, { 0.0017460000000000002d, new GammaParticle(564860.0, 0.00219) }, { 0.001164d, new GammaParticle(858710.0, 0.00144) }, { 0.0034920000000000003d, new GammaParticle(1323700.0, 0.00094) }, { 0.00291d, new GammaParticle(1570500.0, 0.00079) }, { 0.0017460000000000002d, new GammaParticle(1618800.0, 0.00077) }, { 1.01352d, new GammaParticle(511000.0, 0.00243) }, { 0.0301742522336707d, new GammaParticle(1320.0, 0.93927) }, { 0.2256256802092057d, new GammaParticle(10509.0, 0.11798) }, { 0.43785305687794623d, new GammaParticle(10544.0, 0.11759) }, { 0.10011637138933127d, new GammaParticle(11773.0, 0.10531) }, { 0.103900770227848d, new GammaParticle(11791.0, 0.10515) }, { 0.0037843988385167222d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    