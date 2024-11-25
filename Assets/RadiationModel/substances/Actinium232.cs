using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium232 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium232";
        public override double halfLife { get; } = 119.0d;
        public override double atomicWeight { get; } = 232.04203d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium232() }, { 1.0d, new BetaParticle(-1, 1853650.00001) }, { 0.00918d, new GammaParticle(112700.0, 0.011) }, { 0.002295d, new GammaParticle(612000.0, 0.00203) }, { 0.05049000000000001d, new GammaParticle(612000.0, 0.00203) }, { 0.153d, new GammaParticle(665000.0, 0.00186) }, { 0.02754d, new GammaParticle(714400.0, 0.00174) }, { 0.004437d, new GammaParticle(724800.0, 0.00171) }, { 0.02448d, new GammaParticle(735800.0, 0.00169) }, { 0.0038250000000000003d, new GammaParticle(774100.0, 0.0016) }, { 0.01377d, new GammaParticle(785200.0, 0.00158) }, { 0.00918d, new GammaParticle(960600.0, 0.00129) }, { 0.01989d, new GammaParticle(1023500.0, 0.00121) }, { 0.01224d, new GammaParticle(1028100.0, 0.00121) }, { 0.010709999999999999d, new GammaParticle(1056300.0, 0.00117) }, { 0.042839999999999996d, new GammaParticle(1072900.0, 0.00116) }, { 0.021419999999999998d, new GammaParticle(1077500.0, 0.00115) }, { 0.03366d, new GammaParticle(1388000.0, 0.00089) }, { 0.015300000000000001d, new GammaParticle(1437000.0, 0.00086) }, { 0.02448d, new GammaParticle(1593000.0, 0.00078) }, { 0.03519d, new GammaParticle(1642000.0, 0.00076) }, { 0.01989d, new GammaParticle(1815000.0, 0.00068) }, { 0.045899999999999996d, new GammaParticle(1830000.0, 0.00068) }, { 0.01377d, new GammaParticle(1880000.0, 0.00066) }, { 0.08874d, new GammaParticle(1899000.0, 0.00065) }, { 0.05202d, new GammaParticle(1948000.0, 0.00064) }, { 0.05355000000000001d, new GammaParticle(1959000.0, 0.00063) }, { 0.03825d, new GammaParticle(1978000.0, 0.00063) }, { 0.03672d, new GammaParticle(2008000.0, 0.00062) }, { 0.022785210839757243d, new GammaParticle(15784.0, 0.07855) }, { 0.0012396962887703403d, new GammaParticle(89954.0, 0.01378) }, { 0.0020053320750086385d, new GammaParticle(93347.0, 0.01328) }, { 0.0007135664464854301d, new GammaParticle(105566.0, 0.01174) }, { 0.00095403833895102d, new GammaParticle(106894.0, 0.0116) }, { 0.00024047189246558995d, new GammaParticle(108580.0, 0.01142) } } },

        };
    }
}
    