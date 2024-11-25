using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver129 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver129";
        public override double halfLife { get; } = 0.046d;
        public override double atomicWeight { get; } = 128.94432d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium129() }, { 1.0d, new BetaParticle(-1, 5626000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium129() }, { 1.0d, new BetaParticle(-1, 5626000.0) } } },

        };
    }
}
    