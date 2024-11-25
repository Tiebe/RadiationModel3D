using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten167 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten167";
        public override double halfLife { get; } = 19.9d;
        public override double atomicWeight { get; } = 166.95481d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9995999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium167() }, { 1.0d, new BetaParticle(1, 5687500.0) } } },
            { 0.0004d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium163() }, { 1.0d, new AlphaParticle(5773002.09) } } },

        };
    }
}
    