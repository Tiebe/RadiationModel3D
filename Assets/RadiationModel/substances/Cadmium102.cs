using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium102";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 101.91448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium102() }, { 1.0d, new BetaParticle(1, 4121650.0) }, { 0.00035999999999999997d, new GammaParticle(28000.0, 0.04428) }, { 0.0144d, new GammaParticle(59050.0, 0.021) }, { 0.0354d, new GammaParticle(97460.0, 0.01272) }, { 0.0654d, new GammaParticle(116130.0, 0.01068) }, { 0.0276d, new GammaParticle(120470.0, 0.01029) }, { 0.00522d, new GammaParticle(147090.0, 0.00843) }, { 0.0024d, new GammaParticle(156100.0, 0.00794) }, { 0.045d, new GammaParticle(213500.0, 0.00581) }, { 0.0014399999999999999d, new GammaParticle(244400.0, 0.00507) }, { 0.0018d, new GammaParticle(322500.0, 0.00384) }, { 0.0336d, new GammaParticle(360580.0, 0.00344) }, { 0.0015d, new GammaParticle(384000.0, 0.00323) }, { 0.0768d, new GammaParticle(415050.0, 0.00299) }, { 0.6d, new GammaParticle(481000.0, 0.00258) }, { 0.0756d, new GammaParticle(505000.0, 0.00246) }, { 0.0102d, new GammaParticle(531200.0, 0.00233) }, { 0.022799999999999997d, new GammaParticle(555000.0, 0.00223) }, { 0.042d, new GammaParticle(675650.0, 0.00184) }, { 0.0006d, new GammaParticle(920000.0, 0.00135) }, { 0.0028799999999999997d, new GammaParticle(998600.0, 0.00124) }, { 0.138d, new GammaParticle(1036100.0, 0.0012) }, { 0.0015d, new GammaParticle(1079100.0, 0.00115) }, { 0.06d, new GammaParticle(1359200.0, 0.00091) }, { 0.0042d, new GammaParticle(1439600.0, 0.00086) }, { 0.0013800000000000002d, new GammaParticle(1717800.0, 0.00072) }, { 0.0036d, new GammaParticle(1956000.0, 0.00063) }, { 0.255042d, new GammaParticle(511000.0, 0.00243) }, { 0.0512d, new GammaParticle(3218.0, 0.38528) }, { 0.191d, new GammaParticle(21990.0, 0.05638) }, { 0.36d, new GammaParticle(22163.0, 0.05594) }, { 0.0998d, new GammaParticle(25030.0, 0.04953) }, { 0.11699999999999999d, new GammaParticle(25211.0, 0.04918) }, { 0.0174d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    