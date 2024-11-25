using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium42 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium42";
        public override double halfLife { get; } = 0.68079d;
        public override double atomicWeight { get; } = 41.96552d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium42() }, { 1.0d, new BetaParticle(1, 1450515.0) }, { 7.5e-05d, new GammaParticle(313000.0, 0.00396) }, { 7.5e-05d, new GammaParticle(1524000.0, 0.00081) }, { 1.998054d, new GammaParticle(511000.0, 0.00243) }, { 3.312448214236785e-06d, new GammaParticle(358.0, 3.46325) }, { 4.381168268938121e-05d, new GammaParticle(3688.0, 0.33618) }, { 8.656724498988581e-05d, new GammaParticle(3692.0, 0.33582) }, { 1.6897109027233003e-05d, new GammaParticle(4013.0, 0.30896) }, { 1.6897109027233003e-05d, new GammaParticle(4013.0, 0.30896) } } },

        };
    }
}
    