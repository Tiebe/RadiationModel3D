using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium265";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 265.12979d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium261() }, { 1.0d, new AlphaParticle(11492002.09) } } },
            { 0.01d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    