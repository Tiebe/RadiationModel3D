using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279";
        public override double halfLife { get; } = 0.216d;
        public override double atomicWeight { get; } = 279.15998d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.885d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.125d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium275() }, { 1.0d, new AlphaParticle(11127002.09) } } },

        };
    }
}
    