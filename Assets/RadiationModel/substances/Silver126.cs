using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver126 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver126";
        public override double halfLife { get; } = 0.052d;
        public override double atomicWeight { get; } = 125.93481d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium126() }, { 1.0d, new BetaParticle(-1, 5767850.0) }, { 0.46104d, new GammaParticle(82500.0, 0.01503) }, { 0.023504d, new GammaParticle(119200.0, 0.0104) }, { 0.1808d, new GammaParticle(169500.0, 0.00731) }, { 0.040679999999999994d, new GammaParticle(233400.0, 0.00531) }, { 0.12656d, new GammaParticle(251900.0, 0.00492) }, { 0.03723d, new GammaParticle(262800.0, 0.00472) }, { 0.10949999999999999d, new GammaParticle(364500.0, 0.0034) }, { 0.9266d, new GammaParticle(401700.0, 0.00309) }, { 0.11752000000000001d, new GammaParticle(490500.0, 0.00253) }, { 0.0904d, new GammaParticle(545900.0, 0.00227) }, { 0.027120000000000002d, new GammaParticle(570500.0, 0.00217) }, { 0.9989199999999999d, new GammaParticle(651900.0, 0.0019) }, { 0.9854999999999999d, new GammaParticle(651900.0, 0.0019) }, { 0.054240000000000003d, new GammaParticle(657100.0, 0.00189) }, { 0.04972000000000001d, new GammaParticle(715600.0, 0.00173) }, { 0.040679999999999994d, new GammaParticle(737000.0, 0.00168) }, { 0.040679999999999994d, new GammaParticle(777700.0, 0.00159) }, { 0.9989199999999999d, new GammaParticle(814900.0, 0.00152) }, { 0.024089999999999997d, new GammaParticle(814900.0, 0.00152) }, { 0.07446d, new GammaParticle(826800.0, 0.0015) }, { 0.054240000000000003d, new GammaParticle(826800.0, 0.0015) }, { 0.006328d, new GammaParticle(826900.0, 0.0015) }, { 0.07232d, new GammaParticle(856000.0, 0.00145) }, { 0.0678d, new GammaParticle(889000.0, 0.00139) }, { 0.27155999999999997d, new GammaParticle(927100.0, 0.00134) }, { 0.0452d, new GammaParticle(1061800.0, 0.00117) }, { 0.10949999999999999d, new GammaParticle(1082700.0, 0.00115) }, { 0.04599d, new GammaParticle(1082700.0, 0.00115) }, { 0.03723d, new GammaParticle(1150700.0, 0.00108) }, { 0.027120000000000002d, new GammaParticle(1162000.0, 0.00107) }, { 0.14892d, new GammaParticle(1291600.0, 0.00096) }, { 0.040679999999999994d, new GammaParticle(1364200.0, 0.00091) }, { 0.027120000000000002d, new GammaParticle(1492500.0, 0.00083) }, { 0.03066d, new GammaParticle(1554200.0, 0.0008) }, { 0.013796999999999999d, new GammaParticle(1579700.0, 0.00078) }, { 0.05474999999999999d, new GammaParticle(1816900.0, 0.00068) }, { 0.01582d, new GammaParticle(1886700.0, 0.00066) }, { 0.041609999999999994d, new GammaParticle(1893100.0, 0.00065) }, { 0.024089999999999997d, new GammaParticle(1919200.0, 0.00065) }, { 0.032850000000000004d, new GammaParticle(2009100.0, 0.00062) }, { 0.01752d, new GammaParticle(2025900.0, 0.00061) }, { 0.20804999999999998d, new GammaParticle(2183400.0, 0.00057) }, { 0.0219d, new GammaParticle(2226800.0, 0.00056) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    