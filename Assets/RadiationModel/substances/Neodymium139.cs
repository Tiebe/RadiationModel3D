using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium139";
        public override double halfLife { get; } = 1782.0d;
        public override double atomicWeight { get; } = 138.91195d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium139() }, { 1.0d, new BetaParticle(1, 2470350.0) }, { 0.00874d, new GammaParticle(113870.0, 0.01089) }, { 0.0076d, new GammaParticle(183500.0, 0.00676) }, { 0.0007599999999999999d, new GammaParticle(220900.0, 0.00561) }, { 0.00133d, new GammaParticle(368000.0, 0.00337) }, { 0.06916d, new GammaParticle(405000.0, 0.00306) }, { 0.0015199999999999999d, new GammaParticle(411500.0, 0.00301) }, { 0.01311d, new GammaParticle(475500.0, 0.00261) }, { 0.00456d, new GammaParticle(485000.0, 0.00256) }, { 0.007980000000000001d, new GammaParticle(588800.0, 0.00211) }, { 0.012159999999999999d, new GammaParticle(621700.0, 0.00199) }, { 0.0152d, new GammaParticle(669000.0, 0.00185) }, { 0.0038d, new GammaParticle(696200.0, 0.00178) }, { 0.0152d, new GammaParticle(916900.0, 0.00135) }, { 0.013300000000000001d, new GammaParticle(923400.0, 0.00134) }, { 0.02527d, new GammaParticle(1074200.0, 0.00115) }, { 0.0038d, new GammaParticle(1096500.0, 0.00113) }, { 0.0032300000000000002d, new GammaParticle(1213400.0, 0.00102) }, { 0.0028499999999999997d, new GammaParticle(1221200.0, 0.00102) }, { 0.00133d, new GammaParticle(1233300.0, 0.00101) }, { 0.0019d, new GammaParticle(1246700.0, 0.00099) }, { 0.0030399999999999997d, new GammaParticle(1311800.0, 0.00095) }, { 0.0028499999999999997d, new GammaParticle(1328800.0, 0.00093) }, { 0.0060799999999999995d, new GammaParticle(1405500.0, 0.00088) }, { 0.0015199999999999999d, new GammaParticle(1449000.0, 0.00086) }, { 0.0032300000000000002d, new GammaParticle(1463400.0, 0.00085) }, { 0.00247d, new GammaParticle(1500500.0, 0.00083) }, { 0.00133d, new GammaParticle(1532000.0, 0.00081) }, { 0.496492d, new GammaParticle(511000.0, 0.00243) }, { 0.0865253479911348d, new GammaParticle(5637.0, 0.21995) }, { 0.16809256929827365d, new GammaParticle(35551.0, 0.03488) }, { 0.306962325234247d, new GammaParticle(36027.0, 0.03441) }, { 0.09338459670388484d, new GammaParticle(40857.0, 0.03035) }, { 0.11729105346007936d, new GammaParticle(41266.0, 0.03005) }, { 0.02390645675619452d, new GammaParticle(41766.0, 0.02969) } } },

        };
    }
}
    