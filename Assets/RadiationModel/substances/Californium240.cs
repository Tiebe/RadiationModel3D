using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium240";
        public override double halfLife { get; } = 57.6d;
        public override double atomicWeight { get; } = 240.06225d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium236() }, { 1.0d, new AlphaParticle(8733002.09) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    