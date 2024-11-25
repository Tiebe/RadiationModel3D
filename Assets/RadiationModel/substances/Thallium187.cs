using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium187 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium187";
        public override double halfLife { get; } = 51.0d;
        public override double atomicWeight { get; } = 186.9759d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold187() }, { 1.0d, new BetaParticle(1, 5292000.0) } } },
            { 0.0003d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold183() }, { 1.0d, new AlphaParticle(6343002.09) } } },

        };
    }
}
    