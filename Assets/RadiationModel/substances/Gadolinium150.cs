using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium150";
        public override double halfLife { get; } = 56486897494519.68d;
        public override double atomicWeight { get; } = 149.91866d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium146() }, { 1.0d, new AlphaParticle(3829002.09) } } },

        };
    }
}
    