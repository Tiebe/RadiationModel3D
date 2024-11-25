using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon39 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon39";
        public override double halfLife { get; } = 8457256161.19066d;
        public override double atomicWeight { get; } = 38.96431d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium39() }, { 1.0d, new BetaParticle(-1, 282597.5) } } },

        };
    }
}
    