using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium277";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 277.15576d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hassium273() }, { 1.0d, new AlphaParticle(11917002.09) } } },
            { 0.125d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    