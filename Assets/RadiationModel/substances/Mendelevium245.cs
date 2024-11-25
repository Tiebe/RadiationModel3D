using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium245";
        public override double halfLife { get; } = 0.33d;
        public override double atomicWeight { get; } = 245.08087d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium241() }, { 1.0d, new AlphaParticle(10037002.09) } } },

        };
    }
}
    