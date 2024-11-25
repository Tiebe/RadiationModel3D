using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium154";
        public override double halfLife { get; } = 94670777923776.0d;
        public override double atomicWeight { get; } = 153.92443d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium150() }, { 1.0d, new AlphaParticle(3967002.09) } } },

        };
    }
}
    