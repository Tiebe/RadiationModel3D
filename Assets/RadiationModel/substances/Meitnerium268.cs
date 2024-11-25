using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium268";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 268.13865d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bohrium264() }, { 1.0d, new AlphaParticle(11787002.09) } } },

        };
    }
}
    