using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium182";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 181.98569d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold182() }, { 1.0d, new BetaParticle(1, 7488500.0) } } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold178() }, { 1.0d, new AlphaParticle(7573002.09) } } },

        };
    }
}
    