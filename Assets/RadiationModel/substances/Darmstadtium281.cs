using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium281";
        public override double halfLife { get; } = 12.0d;
        public override double atomicWeight { get; } = 281.16454d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium277() }, { 1.0d, new AlphaParticle(10487002.09) } } },

        };
    }
}
    