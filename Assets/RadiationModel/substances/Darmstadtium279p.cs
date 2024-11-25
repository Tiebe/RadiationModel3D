using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium279p : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279p";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 279.16023d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.33299999999999996d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium275() }, { 1.0d, new AlphaParticle(11357002.09) } } },

        };
    }
}
    