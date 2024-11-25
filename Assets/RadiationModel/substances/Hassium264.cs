using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium264";
        public override double halfLife { get; } = 0.0008d;
        public override double atomicWeight { get; } = 264.12836d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Seaborgium260() }, { 1.0d, new AlphaParticle(11613002.09) } } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    