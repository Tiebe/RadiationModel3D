using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium147";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 146.94014d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium147() }, { 1.0d, new BetaParticle(1, 7493000.0) }, { 0.33d, new GammaParticle(189100.0, 0.00656) }, { 0.043d, new GammaParticle(292700.0, 0.00424) }, { 0.052000000000000005d, new GammaParticle(394400.0, 0.00314) }, { 0.028999999999999998d, new GammaParticle(431600.0, 0.00287) }, { 0.054000000000000006d, new GammaParticle(445100.0, 0.00279) }, { 0.2d, new GammaParticle(486700.0, 0.00255) }, { 0.054000000000000006d, new GammaParticle(589000.0, 0.0021) }, { 0.057999999999999996d, new GammaParticle(779600.0, 0.00159) }, { 0.33d, new GammaParticle(883900.0, 0.0014) }, { 0.02d, new GammaParticle(918300.0, 0.00135) }, { 0.07400000000000001d, new GammaParticle(956000.0, 0.0013) }, { 0.12d, new GammaParticle(1263700.0, 0.00098) }, { 1.276d, new GammaParticle(511000.0, 0.00243) }, { 0.015364829040400001d, new GammaParticle(7384.0, 0.16791) }, { 0.02113512820330789d, new GammaParticle(45207.0, 0.02743) }, { 0.03776827770426714d, new GammaParticle(45998.0, 0.02695) }, { 0.012126621819384892d, new GammaParticle(52220.0, 0.02374) }, { 0.015279543492424965d, new GammaParticle(52791.0, 0.02349) }, { 0.0031529216730400724d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    