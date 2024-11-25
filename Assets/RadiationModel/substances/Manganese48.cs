using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese48 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese48";
        public override double halfLife { get; } = 0.1577d;
        public override double atomicWeight { get; } = 47.96855d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium48() }, { 1.0d, new BetaParticle(1, 7590500.0) }, { 0.0021d, new GammaParticle(87000.0, 0.01425) }, { 0.0054d, new GammaParticle(531000.0, 0.00233) }, { 0.997d, new GammaParticle(752100.0, 0.00165) }, { 0.0318d, new GammaParticle(760200.0, 0.00163) }, { 0.39299999999999996d, new GammaParticle(1106100.0, 0.00112) }, { 0.0667d, new GammaParticle(1139700.0, 0.00109) }, { 0.223d, new GammaParticle(1364000.0, 0.00091) }, { 0.0031d, new GammaParticle(1586400.0, 0.00078) }, { 0.021099999999999997d, new GammaParticle(1675000.0, 0.00074) }, { 0.013000000000000001d, new GammaParticle(1728800.0, 0.00072) }, { 0.016399999999999998d, new GammaParticle(2259200.0, 0.00055) }, { 0.0159d, new GammaParticle(2570200.0, 0.00048) }, { 0.022799999999999997d, new GammaParticle(3174100.0, 0.00039) }, { 0.0308d, new GammaParticle(3435500.0, 0.00036) }, { 0.307d, new GammaParticle(3676200.0, 0.00034) }, { 0.0109d, new GammaParticle(3750000.0, 0.00033) }, { 0.106d, new GammaParticle(3900500.0, 0.00032) }, { 0.233d, new GammaParticle(3934100.0, 0.00032) }, { 0.0915d, new GammaParticle(4280100.0, 0.00029) }, { 0.0054d, new GammaParticle(4856100.0, 0.00026) }, { 0.013000000000000001d, new GammaParticle(5040500.0, 0.00025) }, { 1.8266d, new GammaParticle(511000.0, 0.00243) }, { 1.35173266596e-05d, new GammaParticle(597.0, 2.07679) }, { 0.00016017253651902936d, new GammaParticle(5406.0, 0.22935) }, { 0.00031461900710868075d, new GammaParticle(5415.0, 0.22896) }, { 6.39069417722898e-05d, new GammaParticle(5966.0, 0.20782) }, { 6.39069417722898e-05d, new GammaParticle(5966.0, 0.20782) } } },
            { 0.0028000000000000004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium47() }, { 1.0d, new BetaParticle(1, 472102086.736) }, { 1.0d, new ProtonParticle() }, { 0.19d, new GammaParticle(58200.0, 0.0213) }, { 0.19d, new GammaParticle(87500.0, 0.01417) }, { 0.0016d, new GammaParticle(145700.0, 0.00851) }, { 0.0009d, new GammaParticle(172200.0, 0.0072) }, { 0.0066d, new GammaParticle(259400.0, 0.00478) }, { 0.00165d, new GammaParticle(400800.0, 0.00309) }, { 0.00104d, new GammaParticle(514500.0, 0.00241) }, { 0.00078d, new GammaParticle(572500.0, 0.00217) }, { 0.0021d, new GammaParticle(660100.0, 0.00188) }, { 0.00015d, new GammaParticle(536.0, 2.31314) }, { 0.0018d, new GammaParticle(4945.0, 0.25073) }, { 0.0036d, new GammaParticle(4952.0, 0.25037) }, { 0.00073d, new GammaParticle(5444.0, 0.22774) }, { 0.00073d, new GammaParticle(5444.0, 0.22774) } } },
            { 5.999999999999999e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium48() }, { 1.0d, new BetaParticle(1, 6762000.0) } } },

        };
    }
}
    