using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese69 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese69";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 68.97277d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron69() }, { 1.0d, new BetaParticle(-1, 6920000.0) } } },

        };
    }
}
    