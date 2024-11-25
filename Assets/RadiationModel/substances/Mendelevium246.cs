using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium246";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 246.08172d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Einsteinium242() }, { 1.0d, new AlphaParticle(9917002.09) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    