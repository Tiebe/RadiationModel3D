using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium275";
        public override double halfLife { get; } = 0.2d;
        public override double atomicWeight { get; } = 275.14653d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium271() }, { 1.0d, new AlphaParticle(10467002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    