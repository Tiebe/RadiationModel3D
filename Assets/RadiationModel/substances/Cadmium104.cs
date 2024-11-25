using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium104";
        public override double halfLife { get; } = 3462.0d;
        public override double atomicWeight { get; } = 103.90986d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium104() }, { 1.0d, new BetaParticle(1, 2713349.99999) }, { 0.023969999999999998d, new GammaParticle(66600.0, 0.01862) }, { 0.47d, new GammaParticle(83500.0, 0.01485) }, { 0.003525d, new GammaParticle(123700.0, 0.01002) }, { 0.0011279999999999999d, new GammaParticle(150200.0, 0.00825) }, { 0.06344999999999999d, new GammaParticle(559000.0, 0.00222) }, { 0.02162d, new GammaParticle(625700.0, 0.00198) }, { 0.19505d, new GammaParticle(709300.0, 0.00175) }, { 0.075d, new GammaParticle(3218.0, 0.38528) }, { 0.27699999999999997d, new GammaParticle(21990.0, 0.05638) }, { 0.523d, new GammaParticle(22163.0, 0.05594) }, { 0.145d, new GammaParticle(25030.0, 0.04953) }, { 0.17d, new GammaParticle(25211.0, 0.04918) }, { 0.0252d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    