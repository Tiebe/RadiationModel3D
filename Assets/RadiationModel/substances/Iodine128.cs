using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine128 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine128";
        public override double halfLife { get; } = 1499.4d;
        public override double atomicWeight { get; } = 127.90581d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9309999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon128() }, { 1.0d, new BetaParticle(-1, 1061267.0) }, { 0.1261d, new GammaParticle(442901.0, 0.0028) }, { 0.01202994d, new GammaParticle(526557.0, 0.00235) }, { 2.2698000000000002e-05d, new GammaParticle(613493.0, 0.00202) }, { 1.0088e-06d, new GammaParticle(907840.0, 0.00137) }, { 0.00298857d, new GammaParticle(969458.0, 0.00128) }, { 7.6921e-05d, new GammaParticle(1140079.0, 0.00109) }, { 4.7918000000000004e-06d, new GammaParticle(1434400.0, 0.00086) }, { 0.0001460072331706224d, new GammaParticle(4540.0, 0.27309) }, { 0.0003616018327486536d, new GammaParticle(29458.0, 0.04209) }, { 0.0006698811277299992d, new GammaParticle(29778.0, 0.04164) }, { 0.00019419586157231594d, new GammaParticle(33726.0, 0.03676) }, { 0.0002400260849033825d, new GammaParticle(34030.0, 0.03643) }, { 4.583022333106657e-05d, new GammaParticle(34414.0, 0.03603) } } },
            { 0.069d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony128() }, { 1.0d, new BetaParticle(1, -1554000.0) }, { 0.00115d, new GammaParticle(743500.0, 0.00167) }, { 5.2e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.00535420065094554d, new GammaParticle(4135.0, 0.29984) }, { 0.014716588171487624d, new GammaParticle(27202.0, 0.04558) }, { 0.027405192125675274d, new GammaParticle(27473.0, 0.04513) }, { 0.007842888591074045d, new GammaParticle(31093.0, 0.03988) }, { 0.009544795415337114d, new GammaParticle(31359.0, 0.03954) }, { 0.0017019068242630675d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    