using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium266";
        public override double halfLife { get; } = 0.00297d;
        public override double atomicWeight { get; } = 266.13005d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium262() }, { 1.0d, new AlphaParticle(11368002.09) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    