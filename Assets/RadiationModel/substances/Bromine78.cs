using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine78 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine78";
        public override double halfLife { get; } = 387.0d;
        public override double atomicWeight { get; } = 77.92115d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9998999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic78() }, { 1.0d, new BetaParticle(1, -317500.0) }, { 0.136d, new GammaParticle(613680.0, 0.00202) }, { 0.0005848d, new GammaParticle(694800.0, 0.00178) }, { 0.00068d, new GammaParticle(884700.0, 0.0014) }, { 0.00017680000000000001d, new GammaParticle(1144600.0, 0.00108) }, { 0.000136d, new GammaParticle(1228700.0, 0.00101) }, { 0.0004352d, new GammaParticle(1308400.0, 0.00095) }, { 0.00011695999999999999d, new GammaParticle(1338900.0, 0.00093) }, { 2.72e-05d, new GammaParticle(1381800.0, 0.0009) }, { 1.632e-05d, new GammaParticle(1713800.0, 0.00072) }, { 0.0004624d, new GammaParticle(1720700.0, 0.00072) }, { 0.0004896d, new GammaParticle(1923300.0, 0.00064) }, { 5.032e-05d, new GammaParticle(1996300.0, 0.00062) }, { 4.896e-05d, new GammaParticle(2284400.0, 0.00054) }, { 3.536e-05d, new GammaParticle(2391900.0, 0.00052) }, { 0.00017680000000000001d, new GammaParticle(2476500.0, 0.0005) }, { 1.7816e-05d, new GammaParticle(2537300.0, 0.00049) }, { 2.72e-05d, new GammaParticle(2641300.0, 0.00047) }, { 6.12e-06d, new GammaParticle(2769800.0, 0.00045) }, { 3.4e-06d, new GammaParticle(2899500.0, 0.00043) }, { 4.488e-06d, new GammaParticle(3005900.0, 0.00041) }, { 1.8496888960000002d, new GammaParticle(511000.0, 0.00243) }, { 0.00152980295242075d, new GammaParticle(1426.0, 0.86945) }, { 0.01170593652965018d, new GammaParticle(11183.0, 0.11087) }, { 0.022694719910139938d, new GammaParticle(11223.0, 0.11047) }, { 0.005295916244186587d, new GammaParticle(12546.0, 0.09882) }, { 0.005593546737109874d, new GammaParticle(12571.0, 0.09863) }, { 0.0002976304929232862d, new GammaParticle(12652.0, 0.098) } } },
            { 0.0001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton78() }, { 1.0d, new BetaParticle(-1, 363150.0) }, { 7.000000000000001e-05d, new GammaParticle(454000.0, 0.00273) } } },

        };
    }
}
    