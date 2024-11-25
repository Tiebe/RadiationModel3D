using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium271 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium271";
        public override double halfLife { get; } = 0.0016d;
        public override double atomicWeight { get; } = 271.14595d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium267() }, { 1.0d, new AlphaParticle(11887002.09) } } },

        };
    }
}
    