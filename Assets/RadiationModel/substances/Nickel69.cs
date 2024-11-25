using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel69 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel69";
        public override double halfLife { get; } = 11.4d;
        public override double atomicWeight { get; } = 68.93561d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper69() }, { 1.0d, new BetaParticle(-1, 2878600.0) }, { 0.01008d, new GammaParticle(104100.0, 0.01191) }, { 0.0189d, new GammaParticle(154100.0, 0.00805) }, { 0.042d, new GammaParticle(183200.0, 0.00677) }, { 0.2583d, new GammaParticle(205100.0, 0.00605) }, { 0.00378d, new GammaParticle(231400.0, 0.00536) }, { 0.039900000000000005d, new GammaParticle(249100.0, 0.00498) }, { 0.00042d, new GammaParticle(262800.0, 0.00472) }, { 0.1176d, new GammaParticle(470700.0, 0.00263) }, { 0.11424d, new GammaParticle(574900.0, 0.00216) }, { 0.0042d, new GammaParticle(584800.0, 0.00212) }, { 0.39732d, new GammaParticle(680500.0, 0.00182) }, { 0.00504d, new GammaParticle(780800.0, 0.00159) }, { 0.0084d, new GammaParticle(1089300.0, 0.00114) }, { 0.42d, new GammaParticle(1213500.0, 0.00102) }, { 0.00462d, new GammaParticle(1336000.0, 0.00093) }, { 0.013859999999999999d, new GammaParticle(1389500.0, 0.00089) }, { 0.3318d, new GammaParticle(1483600.0, 0.00084) }, { 0.14238d, new GammaParticle(1711900.0, 0.00072) }, { 0.39732d, new GammaParticle(1872300.0, 0.00066) }, { 0.00714d, new GammaParticle(2285000.0, 0.00054) }, { 0.02436d, new GammaParticle(2550000.0, 0.00049) }, { 0.01638d, new GammaParticle(2695000.0, 0.00046) }, { 3.4952701336266e-06d, new GammaParticle(952.0, 1.30236) }, { 3.345566990565768e-05d, new GammaParticle(8028.0, 0.15444) }, { 6.517761524577767e-05d, new GammaParticle(8048.0, 0.15406) }, { 1.3719889964564658e-05d, new GammaParticle(8940.0, 0.13868) }, { 1.3719889964564658e-05d, new GammaParticle(8940.0, 0.13868) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    