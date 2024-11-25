using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium271";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 271.13708d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium267() }, { 1.0d, new AlphaParticle(10477002.09) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    