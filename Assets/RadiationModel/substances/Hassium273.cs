using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium273";
        public override double halfLife { get; } = 0.51d;
        public override double atomicWeight { get; } = 273.14146d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium269() }, { 1.0d, new AlphaParticle(10677002.09) } } },
            { 0.125d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    