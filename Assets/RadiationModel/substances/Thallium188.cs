using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium188 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium188";
        public override double halfLife { get; } = 71.0d;
        public override double atomicWeight { get; } = 187.97602d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold188() }, { 1.0d, new BetaParticle(1, 5017650.00001) } } },

        };
    }
}
    