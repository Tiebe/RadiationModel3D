using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium278";
        public override double halfLife { get; } = 0.0042d;
        public override double atomicWeight { get; } = 278.16159d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium274() }, { 1.0d, new AlphaParticle(11867002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    