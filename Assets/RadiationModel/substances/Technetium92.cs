using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium92";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 91.91527d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium92() }, { 1.0d, new BetaParticle(1, 3763650.0) }, { 0.12082696999999999d, new GammaParticle(85000.0, 0.01459) }, { 0.7089847d, new GammaParticle(148000.0, 0.00838) }, { 0.13280981d, new GammaParticle(243700.0, 0.00509) }, { 0.79785743d, new GammaParticle(329300.0, 0.00377) }, { 0.99857d, new GammaParticle(773000.0, 0.0016) }, { 1.0085557d, new GammaParticle(1509600.0, 0.00082) }, { 0.00199714d, new GammaParticle(1567900.0, 0.00079) }, { 0.002396568d, new GammaParticle(1590900.0, 0.00078) }, { 0.0018972829999999998d, new GammaParticle(1702200.0, 0.00073) }, { 0.01198284d, new GammaParticle(2157000.0, 0.00057) }, { 0.009186844d, new GammaParticle(2305800.0, 0.00054) }, { 0.00099857d, new GammaParticle(2516800.0, 0.00049) }, { 0.00299571d, new GammaParticle(2645200.0, 0.00047) }, { 0.004393708d, new GammaParticle(2702400.0, 0.00046) }, { 0.00399428d, new GammaParticle(2850300.0, 0.00043) }, { 0.0006989990000000001d, new GammaParticle(2881000.0, 0.00043) }, { 0.001597712d, new GammaParticle(2899500.0, 0.00043) }, { 0.005392278d, new GammaParticle(3023400.0, 0.00041) }, { 0.004793136d, new GammaParticle(3128500.0, 0.0004) }, { 0.001198284d, new GammaParticle(3218000.0, 0.00039) }, { 0.001697569d, new GammaParticle(4028000.0, 0.00031) }, { 0.0006989990000000001d, new GammaParticle(4370100.0, 0.00028) }, { 1.7786000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.011145175785682377d, new GammaParticle(2440.0, 0.50813) }, { 0.05480975496145672d, new GammaParticle(17374.0, 0.07136) }, { 0.10445922424520054d, new GammaParticle(17479.0, 0.07093) }, { 0.027409722071440323d, new GammaParticle(19681.0, 0.063) }, { 0.03163081927044213d, new GammaParticle(19794.0, 0.06264) }, { 0.00422109719900181d, new GammaParticle(19963.0, 0.06211) } } },

        };
    }
}
    