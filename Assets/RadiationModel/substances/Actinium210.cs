using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium210";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 210.0094d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Francium206() }, { 1.0d, new AlphaParticle(8604002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    