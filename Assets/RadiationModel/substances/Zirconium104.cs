using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium104";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 103.92945d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium104() }, { 1.0d, new BetaParticle(-1, 3046500.0) }, { 0.017079999999999998d, new GammaParticle(37400.0, 0.03315) }, { 0.00549d, new GammaParticle(49900.0, 0.02485) }, { 0.01403d, new GammaParticle(61100.0, 0.02029) }, { 0.061d, new GammaParticle(100900.0, 0.01229) }, { 0.01464d, new GammaParticle(140900.0, 0.0088) }, { 0.017689999999999997d, new GammaParticle(202400.0, 0.00613) }, { 0.02196d, new GammaParticle(210500.0, 0.00589) }, { 0.03233d, new GammaParticle(213000.0, 0.00582) }, { 0.01647d, new GammaParticle(241900.0, 0.00513) }, { 0.00976d, new GammaParticle(250600.0, 0.00495) }, { 0.041479999999999996d, new GammaParticle(263700.0, 0.0047) }, { 0.00549d, new GammaParticle(274200.0, 0.00452) }, { 0.054900000000000004d, new GammaParticle(445000.0, 0.00279) }, { 0.054900000000000004d, new GammaParticle(504700.0, 0.00246) } } },

        };
    }
}
    