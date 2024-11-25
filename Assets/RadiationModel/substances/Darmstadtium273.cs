using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium273 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium273";
        public override double halfLife { get; } = 0.00019d;
        public override double atomicWeight { get; } = 273.14846d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium269() }, { 1.0d, new AlphaParticle(12397002.09) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    