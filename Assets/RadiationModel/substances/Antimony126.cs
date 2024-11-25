using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126";
        public override double halfLife { get; } = 1067040.0d;
        public override double atomicWeight { get; } = 125.90726d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium126() }, { 1.0d, new BetaParticle(-1, 1837100.0) }, { 0.003984d, new GammaParticle(148700.0, 0.00834) }, { 0.00498d, new GammaParticle(208600.0, 0.00594) }, { 0.013944000000000002d, new GammaParticle(223900.0, 0.00554) }, { 0.023904d, new GammaParticle(278200.0, 0.00446) }, { 0.04482d, new GammaParticle(296500.0, 0.00418) }, { 0.00498d, new GammaParticle(296800.0, 0.00418) }, { 0.8326560000000001d, new GammaParticle(414700.0, 0.00299) }, { 0.00996d, new GammaParticle(415300.0, 0.00299) }, { 0.016932d, new GammaParticle(556300.0, 0.00223) }, { 0.066732d, new GammaParticle(573900.0, 0.00216) }, { 0.0747d, new GammaParticle(593200.0, 0.00209) }, { 0.008964d, new GammaParticle(619900.0, 0.002) }, { 0.008964d, new GammaParticle(638800.0, 0.00194) }, { 0.021911999999999997d, new GammaParticle(656300.0, 0.00189) }, { 0.996d, new GammaParticle(666500.0, 0.00186) }, { 0.036852d, new GammaParticle(674800.0, 0.00184) }, { 0.008964d, new GammaParticle(684700.0, 0.00181) }, { 0.996d, new GammaParticle(695000.0, 0.00178) }, { 0.31872d, new GammaParticle(697000.0, 0.00178) }, { 0.53784d, new GammaParticle(720700.0, 0.00172) }, { 0.000498d, new GammaParticle(726000.0, 0.00171) }, { 0.0012948d, new GammaParticle(730700.0, 0.0017) }, { 0.176292d, new GammaParticle(856800.0, 0.00145) }, { 0.007968d, new GammaParticle(934000.0, 0.00133) }, { 0.011952d, new GammaParticle(953700.0, 0.0013) }, { 0.00498d, new GammaParticle(958300.0, 0.00129) }, { 0.067728d, new GammaParticle(989600.0, 0.00125) }, { 0.00996d, new GammaParticle(1036200.0, 0.0012) }, { 0.003984d, new GammaParticle(1061300.0, 0.00117) }, { 0.008964d, new GammaParticle(1064400.0, 0.00116) }, { 0.0026892d, new GammaParticle(1191000.0, 0.00104) }, { 0.023904d, new GammaParticle(1213300.0, 0.00102) }, { 0.0022908d, new GammaParticle(1290000.0, 0.00096) }, { 0.0027888d, new GammaParticle(1476900.0, 0.00084) }, { 0.0008964d, new GammaParticle(1589000.0, 0.00078) }, { 0.0019298942952161399d, new GammaParticle(4135.0, 0.29984) }, { 0.005261667135908476d, new GammaParticle(27202.0, 0.04558) }, { 0.009798262822920812d, new GammaParticle(27473.0, 0.04513) }, { 0.002804092135308723d, new GammaParticle(31093.0, 0.03988) }, { 0.0034125801286707166d, new GammaParticle(31359.0, 0.03954) }, { 0.000608487993361993d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    