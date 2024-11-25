using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen17 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen17";
        public override double halfLife { get; } = 4.173d;
        public override double atomicWeight { get; } = 17.00845d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen17() }, { 1.0d, new BetaParticle(-1, 4339382.1) }, { 0.0305d, new GammaParticle(870732.0, 0.00142) }, { 0.0032d, new GammaParticle(2184490.0, 0.00057) }, { 7.000000000000001e-05d, new GammaParticle(3843300.0, 0.00032) } } },
            { 0.951d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen17() }, { 1.0d, new BetaParticle(-1, 4339382.1) }, { 0.0305d, new GammaParticle(870732.0, 0.00142) }, { 0.0032d, new GammaParticle(2184490.0, 0.00057) }, { 7.000000000000001e-05d, new GammaParticle(3843300.0, 0.00032) } } },
            { 2.5e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen17() }, { 1.0d, new BetaParticle(-1, 4339382.1) }, { 0.0305d, new GammaParticle(870732.0, 0.00142) }, { 0.0032d, new GammaParticle(2184490.0, 0.00057) }, { 7.000000000000001e-05d, new GammaParticle(3843300.0, 0.00032) } } },

        };
    }
}
    