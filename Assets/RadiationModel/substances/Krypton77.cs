using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton77 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton77";
        public override double halfLife { get; } = 4275.0d;
        public override double atomicWeight { get; } = 76.92467d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Selenium77() }, { 1.0d, new BetaParticle(1, 2215000.0) }, { 0.0003645d, new GammaParticle(24200.0, 0.05123) }, { 0.012960000000000001d, new GammaParticle(105870.0, 0.01171) }, { 0.81d, new GammaParticle(129640.0, 0.00956) }, { 0.3726d, new GammaParticle(146590.0, 0.00846) }, { 0.002268d, new GammaParticle(161900.0, 0.00766) }, { 0.0016200000000000001d, new GammaParticle(166700.0, 0.00744) }, { 0.02916d, new GammaParticle(276000.0, 0.00449) }, { 0.0018629999999999999d, new GammaParticle(287900.0, 0.00431) }, { 0.03726d, new GammaParticle(311900.0, 0.00398) }, { 0.001134d, new GammaParticle(588200.0, 0.00211) }, { 0.003321d, new GammaParticle(606500.0, 0.00204) }, { 0.000486d, new GammaParticle(698100.0, 0.00178) }, { 0.004293d, new GammaParticle(734900.0, 0.00169) }, { 0.000243d, new GammaParticle(748300.0, 0.00166) }, { 0.001539d, new GammaParticle(837500.0, 0.00148) }, { 0.0020250000000000003d, new GammaParticle(861500.0, 0.00144) }, { 0.0002997d, new GammaParticle(864400.0, 0.00143) }, { 0.0010530000000000001d, new GammaParticle(894900.0, 0.00139) }, { 0.000243d, new GammaParticle(968200.0, 0.00128) }, { 0.0004374d, new GammaParticle(991700.0, 0.00125) }, { 0.0001053d, new GammaParticle(1031300.0, 0.0012) }, { 0.0004617d, new GammaParticle(1158500.0, 0.00107) }, { 0.0039689999999999994d, new GammaParticle(1300000.0, 0.00095) }, { 0.001134d, new GammaParticle(1446400.0, 0.00086) }, { 0.0001458d, new GammaParticle(1479700.0, 0.00084) }, { 0.0003078d, new GammaParticle(1576000.0, 0.00079) }, { 0.00027539999999999997d, new GammaParticle(1999700.0, 0.00062) }, { 4.0499999999999995e-05d, new GammaParticle(2031700.0, 0.00061) }, { 0.0001296d, new GammaParticle(2063900.0, 0.0006) }, { 0.0001539d, new GammaParticle(2068300.0, 0.0006) }, { 0.00017010000000000001d, new GammaParticle(2129100.0, 0.00058) }, { 1.68276d, new GammaParticle(511000.0, 0.00243) }, { 0.008d, new GammaParticle(1535.0, 0.80771) }, { 0.0553d, new GammaParticle(11879.0, 0.10437) }, { 0.107d, new GammaParticle(11925.0, 0.10397) }, { 0.0253d, new GammaParticle(13345.0, 0.09291) }, { 0.0273d, new GammaParticle(13377.0, 0.09268) }, { 0.0019500000000000001d, new GammaParticle(13469.0, 0.09205) } } },

        };
    }
}
    