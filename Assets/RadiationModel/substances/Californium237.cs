using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium237";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 237.0622d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium233() }, { 1.0d, new AlphaParticle(9247002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    