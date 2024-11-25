using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium281";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 281.16675d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium277() }, { 1.0d, new AlphaParticle(10917002.09) } } },

        };
    }
}
    