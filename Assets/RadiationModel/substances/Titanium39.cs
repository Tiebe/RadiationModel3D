using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium39 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium39";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 39.00268d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium39() }, { 1.0d, new BetaParticle(1, 14891350.0) }, { 0.22d, new GammaParticle(511000.0, 0.00243) }, { 3.1420550479999996e-07d, new GammaParticle(422.0, 2.93801) }, { 4.030224143542878e-06d, new GammaParticle(4086.0, 0.30344) }, { 7.950728237409505e-06d, new GammaParticle(4091.0, 0.30307) }, { 1.5802876190476191e-06d, new GammaParticle(4474.0, 0.27712) }, { 1.5802876190476191e-06d, new GammaParticle(4474.0, 0.27712) } } },
            { 0.937d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium38() }, { 1.0d, new ProtonParticle() }, { 0.28d, new GammaParticle(2212500.0, 0.00056) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium37() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    