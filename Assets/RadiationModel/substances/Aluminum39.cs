using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum39 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum39";
        public override double halfLife { get; } = 0.0076d;
        public override double atomicWeight { get; } = 39.02307d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silicon39() }, { 1.0d, new BetaParticle(-1, 9585000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    