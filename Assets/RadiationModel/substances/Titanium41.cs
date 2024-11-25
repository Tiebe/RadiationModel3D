using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium41 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium41";
        public override double halfLife { get; } = 0.0819d;
        public override double atomicWeight { get; } = 40.98315d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium41() }, { 1.0d, new BetaParticle(1, 9719955.0) }, { 2.0318d, new GammaParticle(511000.0, 0.00243) }, { 2.232788031768e-06d, new GammaParticle(422.0, 2.93801) }, { 2.8640739238464107e-05d, new GammaParticle(4086.0, 0.30344) }, { 5.6501754268029416e-05d, new GammaParticle(4091.0, 0.30307) }, { 1.1230294893506494e-05d, new GammaParticle(4474.0, 0.27712) }, { 1.1230294893506494e-05d, new GammaParticle(4474.0, 0.27712) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium40() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    